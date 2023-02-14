namespace CopywritingWebSite.Service.Interfaces.Common
{
    public interface IEmailService
    {
        public Task<bool> SendAsync(string email);
    }
}


//public Task<bool> SendAsync(EmailMessageViewModel message);