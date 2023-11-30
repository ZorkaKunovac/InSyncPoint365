using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Core.Enums;

namespace SyncPoint365.API.Helpers
{
    public class Authorization : TypeFilterAttribute
    {
        public Authorization(params Role[] roles) : base(typeof(AuthorizationFilter))
        {
            Arguments = new object[] { roles };
        }
    }

    public class AuthorizationFilter : IAsyncAuthorizationFilter
    {
        private readonly Role[] _roles;
        private readonly IUsersService _usersService;

        public AuthorizationFilter(Role[] roles, IUsersService usersService)
        {
            _roles = roles; 
            _usersService = usersService;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            var userIdClaim = user.Claims.FirstOrDefault(c => c.Type == "Id");
            if (userIdClaim == null)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var userIdValue = int.Parse(userIdClaim.Value);
            var userFromDatabase = await _usersService.GetByIdAsync(userIdValue);
            if (userFromDatabase == null)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            if (userFromDatabase.Role != Role.SuperAdministrator)
            {
                if (_roles.Contains(userFromDatabase.Role))
                {
                    // Sve okej, dozvoli
                    return;
                }
                else
                {
                    context.Result = new UnauthorizedResult();
                }
            }
        }
    }
}
