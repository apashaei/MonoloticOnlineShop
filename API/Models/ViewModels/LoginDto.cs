using System.ComponentModel.DataAnnotations;

namespace API.Models.ViewModels
{
    public class LoginDto
    {

        [Required(ErrorMessage ="ایمیل اجباری می باشد")]
        public string Email { get; set; }

        [Required(ErrorMessage ="رمز عبور اجباری می باشد")]
        
        public string Password { get; set; }

        public bool IsPersistance { get; set; }
        public string ReturnUrl { get; set; }
    }
}
