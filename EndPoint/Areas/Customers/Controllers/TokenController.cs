using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using Project.Application.Token;
using Project.EndPoint.Utilities;
using System.IdentityModel.Tokens.Jwt;

namespace Project.EndPoint.Areas.Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenServices tokenServices;

        public TokenController(ITokenServices tokenServices)
        {
            this.tokenServices = tokenServices;
        }
        public IActionResult RecieveToken(string Token, string refreshToken, string apiKey)
        {
            if (apiKey != "mysecretkey")
            {
                return BadRequest();
            }
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(Token); // Decodes the token

            var userIdClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == "UserId");

            tokenServices.SaveToken(Token, refreshToken, userIdClaim.Value);
            return Ok();
        }
    }
}
