namespace CopywritingWebSite.Service.Interfaces
{
    public interface IUserService
    {
        public Task<bool> DeleteAsync(string email);
    }
}
