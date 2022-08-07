using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Valhalla.Application.Requests;
using Valhalla.Infrastructure.Persistence;

namespace ValhallaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private ValhallaContext _context;

        public TokenController(ValhallaContext context)
        {
            _context = context;
        }

        [HttpPost]

        public IActionResult GetToken(JwtAuthenticationRequest jwtAuthentication)
        {
            var isValidUser = ValidateUser(jwtAuthentication);
            if (!isValidUser)
            {
                return Unauthorized();
            }
            var token = GenerateToken(jwtAuthentication.Username);
            return Ok(new { token });
        }

        private bool ValidateUser(JwtAuthenticationRequest jwtAuthentication)
        {
            var credentials = _context.JwtAuthentications.FirstOrDefault(x => x.Username == jwtAuthentication.Username && x.Password == jwtAuthentication.Password);
            if (credentials != null)
            {
                return true;
            }
            return false;
        }

        private string GenerateToken(string Username)
        {
            //header
            var privateKey = "v1d1g17dghf56g4d6gfd84gdd56fg4dfgddfg8";
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(privateKey));
            var signinCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(signinCredentials);

            //payload

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, Username),
                new Claim(ClaimTypes.Role, "Admin"),
            };

            var payload = new JwtPayload
                (
                    "https://localhost:44363",
                    "https://localhost:44363",
                    claims,
                    DateTime.Now,
                    DateTime.Now.AddMinutes(5)
                );

            //signature

            var token = new JwtSecurityToken(header, payload);
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
    }
}
