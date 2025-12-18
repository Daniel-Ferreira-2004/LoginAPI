using System.ComponentModel.DataAnnotations;

namespace LoginAPI.ViewModels
{
    public class ChangePassowordViewModel
    {
        [Required(ErrorMessage = "Email is Requerid")]
        [EmailAddress]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 40 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]

        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public string ConfirmNewPassword { get; set; }
    }
}
