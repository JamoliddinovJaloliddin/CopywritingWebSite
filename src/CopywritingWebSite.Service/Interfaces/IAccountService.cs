using CopywritingWebSite.Service.Dtos.Acccount;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface IAccountService
    {
        public Task<string> RegisterAsync(AccountRegisterDto dto);
        public Task<string> LoginAsync( AccountLoginDto dto);
        public Task SendEmail(string email);

    }
}
