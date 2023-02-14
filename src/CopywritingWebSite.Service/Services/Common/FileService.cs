using CopywritingWebSite.Service.Common.Helpers;
using CopywritingWebSite.Service.Interfaces.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace CopywritingWebSite.Service.Services.Common
{
    public class FileService : IFileService
    {
        private readonly string images = "images";
        private readonly string _rootpath;

        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _rootpath = webHostEnvironment.WebRootPath;
        }
        public async Task<string> SaveImageAsync(IFormFile formFile)
        {
            string imageName = ImageHelper.MakeImageName(formFile.FileName);
            try
            {
                string imagePath = Path.Combine("wwwroot", images, imageName);
                var stream = new FileStream(imagePath, FileMode.Create);

                await formFile.CopyToAsync(stream);
                return Path.Combine(images, imageName);
            }
            catch
            {
                return "";
            }
        }
    }
}




