using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CopywritingWebSite.Service.Dtos.Acccount
{
    public class AccountRegisterDto
    {
        [Required, MinLength(2), MaxLength(20)]
        public string Login { get; set; } = String.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = String.Empty;
        [Required, MinLength(8)]
        public string Password { get; set; } = String.Empty;
        [Required]
        public UserRole UserRole { get; set; }

        public static implicit operator User(AccountRegisterDto dto)
        {
            return new User()
            {
                Login = dto.Login,
                Email = dto.Email,
                Role = dto.UserRole,
            };
        }
    }
}
