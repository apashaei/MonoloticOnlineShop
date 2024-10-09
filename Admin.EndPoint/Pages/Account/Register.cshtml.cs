using Admin.EndPoint.ViewModels.Account;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Domain.User;

namespace Admin.EndPoint.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<User> userManager;

        public RegisterModel(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        [BindProperty]
        public RegisterViewModel model { get; set; }

        public List<string> Message { get; set; }= new List<string>();
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                Message.Add("لطفا فرم را به درستی وارد کنید");
            }
            if (!model.AcceptRules)
            {
                Message.Add("لطفا قوانین و ضوابط را تیک بزنید.");
            }
            else
            {
                User newUser = new User()
                {
                    Email = model.Email,
                    FullName = model.FullName,
                    UserName = model.Email,
                    

                };
                var result = userManager.CreateAsync(newUser, model.Password).Result;
                if (result.Succeeded)
                {
                    Message.Add("ثبت نام با موفقیت انجام شد.");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        Message.Add(error.Description);
                    }
                }
            }
            
        }
    }
}
