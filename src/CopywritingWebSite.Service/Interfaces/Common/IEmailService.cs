namespace CopywritingWebSite.Service.Interfaces.Common
{
    public interface IEmailService
    {
        public Task<int> SendAsync(string email);
    }
}

