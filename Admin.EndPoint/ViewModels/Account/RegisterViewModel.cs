using System.ComponentModel.DataAnnotations;

namespace Admin.EndPoint.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "وارد کردن نام کاربری الزامی می باشد.")]
        [Display(Name = "نام کاربری")]
        public string Email { get; set; }

        [Required(ErrorMessage = "پسورد الزامی می باشد")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Required(ErrorMessage ="لطفا شرایط و ضوابط را مطالعه کنید.")]
        public bool AcceptRules { get; set; }

        [Required(ErrorMessage = "لطفا نام و نام خانوادگی را وارد کنید..")]
        public string FullName { get; set; }
    }
}
