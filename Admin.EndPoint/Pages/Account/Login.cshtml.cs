using Admin.EndPoint.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Domain.User;

namespace Admin.EndPoint.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        

        public LoginModel(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public string Message { get; set; }

        [BindProperty]
        public LoginViewModel loginViewModel { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (loginViewModel == null)
            {
                Message = "نام کاربری یا رمز عبور الزامی می باشد";
                return Page();
            }

            var user = userManager.FindByNameAsync(loginViewModel.Email).Result;
            if (user == null)
            {
                Message = "کاربر یافت نشد.";
                return Page();
            }
            signInManager.SignOutAsync();
            var result = signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.IsPersistance, true).Result;
            if (result.Succeeded)
            {
                var roles =  userManager.GetRolesAsync(user);
                return Redirect("/Visitors/index");
            }
            return Page();
        }
    }
}
