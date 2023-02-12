namespace CopywritingWebSite.Service.Interfaces
{
    public interface IEmailService
    {
        public Task<bool> SendAsync(string email);
    }
}


//public Task<bool> SendAsync(EmailMessageViewModel message);