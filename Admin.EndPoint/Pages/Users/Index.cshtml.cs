using Admin.EndPoint.ViewModels.User;
using Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Project.Application.Dtos;
using Project.Domain.User;

namespace Admin.EndPoint.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<User> user;
        private readonly RoleManager<IdentityRole> role;

        public IndexModel(UserManager<User> user, RoleManager<IdentityRole> role)
        {
            this.user = user;
            this.role = role;
        }

        public PagenatedItemDto<UserViewModel> model { get; set; }
        public void OnGet(int Page=1, int Pagesize=20)
        {
            var users  = user.Users.ToPaged(Page,Pagesize, out int rowCount).Select(p=> new UserViewModel
            {
                Email = p.Email,
                Id = p.Id,
                PhoneNumber = p.PhoneNumber,
                UserName = p.UserName,
                FullName = p.FullName,
            }).ToList();
            model = new PagenatedItemDto<UserViewModel>(Page,Pagesize, rowCount,users);
        }
    }
}
