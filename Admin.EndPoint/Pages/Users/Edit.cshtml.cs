using Admin.EndPoint.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Domain.Attributes;
using Project.Domain.User;

namespace Admin.EndPoint.Pages.Users
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> role;

        public EditModel(UserManager<User> userManager, RoleManager<IdentityRole> role)
        {
            this.userManager = userManager;
            this.role = role;
        }

        [BindProperty]
        public UserViewModel ViewModel { get; set; } = new UserViewModel();

        public List<IdentityRole> Roles { get; set; }

        public string Messagge { get; set; }

        public void OnGet(string Id)
        {
            var user = userManager.FindByIdAsync(Id).Result;
            Roles = role.Roles.ToList();
            ViewModel.Id = Id;
            ViewModel.PhoneNumber = user.PhoneNumber;
            ViewModel.FullName = user.FullName;
            ViewModel.Email = user.Email;
        }
        public void OnPost()
        {

            var user = userManager.FindByIdAsync(ViewModel.Id).Result;
            if (user != null)
            {
                user.UserName = ViewModel.Email;
                user.Email = ViewModel.Email;
                user.PhoneNumber = ViewModel.PhoneNumber;
                user.FullName = ViewModel.FullName;
            }
            var userUpdate = userManager.UpdateAsync(user).Result;
            if (!userUpdate.Succeeded)
            {
                TempData["Message"] = "error.";
                TempData["MessageType"] = "error";
                Roles = role.Roles.ToList();

            }
            var currentRole = userManager.GetRolesAsync(user).Result;
            if(currentRole != null)
            {
                var removeResult =  userManager.RemoveFromRolesAsync(user, currentRole).Result;
                if (!removeResult.Succeeded)
                {
                    TempData["Message"] = "خطایی رخ داده است.";
                    TempData["MessageType"] = "error";
                    Roles = role.Roles.ToList();

                }
            }

            var selectedRole = role.FindByIdAsync(ViewModel.RoleId.ToString()).Result;
            if (selectedRole != null)
            {
                var roleExists = role.RoleExistsAsync(selectedRole.Name).Result;
                if (!roleExists)
                {
                    role.CreateAsync(new IdentityRole(selectedRole.Name)).Wait();
                }
                var addToRoleResult = userManager.AddToRoleAsync(user, selectedRole.Name.ToLower()).Result;
                if (!addToRoleResult.Succeeded)
                {
                    TempData["Message"] = "خطایی رخ داده است.";
                    TempData["MessageType"] = "error";
                    Roles = role.Roles.ToList();

                }
            }

            TempData["Message"] = "Success.";
            TempData["MessageType"] = "success";
            Roles = role.Roles.ToList();

        }
    }
}
