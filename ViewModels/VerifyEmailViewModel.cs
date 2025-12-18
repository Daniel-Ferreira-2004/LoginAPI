using System.ComponentModel.DataAnnotations;

namespace LoginAPI.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string email { get; set; }
    }
}
