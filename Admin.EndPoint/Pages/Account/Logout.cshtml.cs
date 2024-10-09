using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Domain.User;

namespace Admin.EndPoint.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        public LogoutModel(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult OnGet()
        {
            _signInManager.SignOutAsync();
            return Redirect("/account/login");
        }
    }
}
