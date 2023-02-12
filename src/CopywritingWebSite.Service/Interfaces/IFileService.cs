using Microsoft.AspNetCore.Http;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface IFileService
    {
        public Task<string> SaveImageAsync(IFormFile formFile);
    }
}
