using Microsoft.AspNetCore.Http;

namespace CopywritingWebSite.Service.Interfaces.Common
{
    public interface IFileService
    {
        public Task<string> SaveImageAsync(IFormFile formFile);
    }
}
