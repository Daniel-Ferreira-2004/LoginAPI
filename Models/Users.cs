using Microsoft.AspNetCore.Identity;

namespace LoginAPI.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
