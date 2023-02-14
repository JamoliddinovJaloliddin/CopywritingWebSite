using CopywritingWebSite.Domain.Entities;

namespace CopywritingWebSite.Service.Interfaces.Common
{
    public interface IAuthManagaer
    {
        public string GenerateToken(User user);
    }
}
