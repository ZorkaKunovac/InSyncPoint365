using Microsoft.AspNetCore.Mvc;
using SyncPoint365.API.Helpers;
using SyncPoint365.Core.DTOs.User;
using SyncPoint365.Application.Interfaces.Services;
using SyncPoint365.Core.Enums;

namespace SyncPoint365.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorization(Role.SuperAdministrator, Role.Administrator)]
    public class UsersController : BaseController<UserDTO, UserAddDTO, UserUpdateDTO>
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService) : base(usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers(string? query = null, int page = 1, int? cityId = null, CancellationToken cancellationToken = default)
        {
            var pagedList = await _usersService.GetUsersAsync(query, page, cityId, cancellationToken);

            return Ok(GetPagedResult(pagedList));
        }
    }
}
