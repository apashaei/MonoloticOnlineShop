using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Application.BasketServices;
using Project.Application.Token;
using Project.Domain.User;
using Project.EndPoint.Areas.Customers.Utilities;
using Project.EndPoint.Models.ViewModels.User;
using Project.EndPoint.Models.ViewModels.User;
using Project.EndPoint.Utilities.Filters;
using System.Runtime.CompilerServices;

namespace Project.EndPoint.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IBasketServices _basketServices;
        private readonly ITokenServices tokenServices;

        public AccountController(UserManager<User> userManager,SignInManager<User> signInManager, IBasketServices basketServices, ITokenServices tokenServices)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _basketServices = basketServices;
            this.tokenServices = tokenServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string ReturnUrl = "/")
        {
            return View(new LoginViewModel
            {
                ReturnUrl = ReturnUrl
            });
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {

                
                return View(model);
            }
            var user = _userManager.FindByNameAsync(model.Email).Result;
            if (user == null)
            {
                ModelState.AddModelError("", "کاربر یافت نشد.");
                return View(model);
            }
            _signInManager.SignOutAsync();
            var result = _signInManager.PasswordSignInAsync(user,model.Password,model.IsPersistance,true).Result;
            if (result.Succeeded)
            {
                var token = tokenServices.GetUserTokn(user.Id);
                if (token == null)
                {
                    var TokenRefreshToken = TokenUtilities.CreateToken(user.Id,user.Email);
                    tokenServices.SaveToken(TokenRefreshToken[0], TokenRefreshToken[1],user.Id);
                }
                TransferCart(user.Id);
                return Redirect(model.ReturnUrl);
            }
            return View(model);
        }

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                User newUser = new User()
                {
                    Email = model.Email,
                    FullName = model.FullName,
                    UserName = model.Email,
                    PhoneNumber = model.PhoneNumber,

                };
                var result = _userManager.CreateAsync(newUser,model.Password).Result;
                if (result.Succeeded)
                {
                    var user = _userManager.FindByEmailAsync(model.Email).Result;
                    TransferCart(user.Id);
                    _signInManager.SignInAsync(user,true).Wait();
                    return RedirectToAction(nameof(Profile));
                }
                else
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }
            return View(model);
        }

        public IActionResult Profile()
        {
            return View();
        }

        private void TransferCart(string UserId)
        {
            string CookeiName = "BasketId";
            if (Request.Cookies.ContainsKey(CookeiName))
            {

                _basketServices.TransferBasketToUser(Request.Cookies[CookeiName], UserId);
                Response.Cookies.Delete(CookeiName);
            }
        }
    }
}
