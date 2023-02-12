using System.ComponentModel.DataAnnotations;

namespace CopywritingWebSite.Service.Dtos.Acccount
{
    public class AccountLoginDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = String.Empty;
        [Required]
        public string Password { get; set; } = String.Empty;
    }
}
