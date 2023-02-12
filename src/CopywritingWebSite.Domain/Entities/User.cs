using CopywritingWebSite.Domain.Commons;
using CopywritingWebSite.Domain.Enums;

namespace CopywritingWebSite.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string PasswordHash { get; set; } = String.Empty;
        public string Salt { get; set; } = String.Empty;
        public UserRole Role { get; set; }
        public string CreateAt { get; set; } = String.Empty;
    }
}
