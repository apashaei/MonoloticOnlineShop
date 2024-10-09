using System.ComponentModel.DataAnnotations;

namespace Admin.EndPoint.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "وارد کردن نام کاربری الزامی می باشد.")]
        [Display(Name = "نام کاربری")]
        public string Email { get; set; }

        [Required(ErrorMessage = "پسورد الزامی می باشد")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        public bool IsPersistance { get; set; }
        public string ReturnUrl { get; set; }
    }
}
