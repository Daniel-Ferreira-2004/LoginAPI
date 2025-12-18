using System.ComponentModel.DataAnnotations;

namespace LoginAPI.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "Remember Me")]
        public bool rememberMe { get; set; }
    }
}
