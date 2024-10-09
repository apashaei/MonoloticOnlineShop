using API.Models.ViewModels;
using API.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Token;
using Project.Domain.User;
using Project.Infrastructure.ExternalApi.SendToken;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountController : ControllerBase
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenServices tokenServices;
        private readonly ISendToken sendToken;

        public UserAccountController(UserManager<User> userManager, SignInManager<User> signInManager, ITokenServices tokenServices,ISendToken sendToken)
        {
            _signInManager = signInManager;
            this.tokenServices = tokenServices;
            this.sendToken = sendToken;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Login ([FromQuery] LoginDto model)
        {
          
            var user = _userManager.FindByNameAsync(model.Email).Result;
            if (user == null)
            {
                return NotFound();
            }
            _signInManager.SignOutAsync();
            var result = _signInManager.PasswordSignInAsync(user, model.Password, model.IsPersistance, true).Result;
            if (result.Succeeded)
            {
               
                    var TokenRefreshToken = TokenUtility.CreateToken(user.Id, user.Email);
                    var send = sendToken.SendToken(TokenRefreshToken[0], TokenRefreshToken[1]);

                    if (send)
                    {
                        return Ok();
                    }
                    else
                    {
                        return BadRequest();
                    }
            }
            return NotFound();
           
        }
        [HttpGet]
        [Route("SendRefreshToken")]
        public IActionResult SendRefreshToken(string refreshToken)
        {
            var user = _userManager.GetUserAsync(User).Result;
            var TokenRefreshToken = TokenUtility.CreateToken(user.Id, user.Email);
            var send = sendToken.SendToken(TokenRefreshToken[0], TokenRefreshToken[1]);
            if (send)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
