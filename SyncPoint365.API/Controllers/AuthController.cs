using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SyncPoint365.API.Config;
using SyncPoint365.API.Helpers;
using SyncPoint365.API.Models;
using SyncPoint365.Application.Helpers;
using SyncPoint365.Application.Interfaces.Services;

namespace SyncPoint365.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsersService _usersService;
        private readonly IOptions<JWTOptions> _jwtOptions;

        public AuthController(IUsersService usersService, IOptions<JWTOptions> jwtOptions)
        {
            _usersService = usersService;
            _jwtOptions = jwtOptions;
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(AuthModel model, CancellationToken cancellationToken = default)
        {
            //1. Dohvatiti korisnika iz baze na osnovu mail-a
            var user = await _usersService.GetByEmailAsync(model.Email, cancellationToken);

            //2. Provjeriti da li korisnik postoji
            if (user == null)
                return NotFound();

            //3. Provjeriti da li je lozinka ispravna
            var hash = Cryptography.GenerateHash(model.Password, user.PasswordSalt);
            if (user.PasswordHash == hash)
            {
                var issuer = _jwtOptions.Value.Issuer;
                var audience = _jwtOptions.Value.Audience;
                var key = Encoding.ASCII.GetBytes(_jwtOptions.Value.Key);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                        new Claim("Id", user.Id.ToString()),
                        new Claim(JwtRegisteredClaimNames.Sub, user.FullName),
                        new Claim(JwtRegisteredClaimNames.Email, user.BusinessEmail),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(_jwtOptions.Value.Duration),
                    Issuer = issuer,
                    Audience = audience,
                    SigningCredentials = new SigningCredentials (new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var jwtToken = tokenHandler.WriteToken(token);

                return Ok(new
                {
                    JwtToken = jwtToken
                });
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
