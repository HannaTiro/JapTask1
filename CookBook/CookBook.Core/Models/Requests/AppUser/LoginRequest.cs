using System.ComponentModel.DataAnnotations;

namespace CookBook.Core.Models.Requests.AppUser
{
    public class LoginRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
