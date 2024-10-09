using System.ComponentModel.DataAnnotations;

namespace Project.EndPoint.Models.ViewModels.User
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "نام و نام خانوادگی اجباری می باشد")]
        [MaxLength(100, ErrorMessage = "نام و نام خانوادگی نمیتواند بیشتر از 100 گاراکتر باشد.")]
        [Display(Name = "نام و نام خانوادگی")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "ایمیل اجباری می باشد.")]
        [EmailAddress(ErrorMessage = "قرمت ایمیل صحیح نمی باشد.")]
        [Display(Name = "ادرس ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage = "پسورد اجباری میباشد.")]
        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "تکرار پسورد اجباری میباشد.")]
        [Display(Name = "تکرار رمز عبور")]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }
        public string PhoneNumber { get; set; }
    }
}
