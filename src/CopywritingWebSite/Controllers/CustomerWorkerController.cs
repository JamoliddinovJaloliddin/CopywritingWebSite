using CopywritingWebSite.Service.Dtos.ArticleDto;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.Controllers
{
    [Route("customerWorker")]
    public class CustomerWorkerController : Controller
    {
        private readonly IArticleService _articleService;
        public CustomerWorkerController(IArticleService articleService)
        {
            this._articleService = articleService;
        }

        public ViewResult Login() => View("DesktopWindow");

        //[HttpGet("get")]
        //public async Task<IActionResult> Get()
        //{
        //    return View("CustomerWorkerTable");
        //}

        //[HttpGet("tableAdd")]
        //public async Task<IActionResult> GetTable()
        //{
        //    return View("CustomerWorkerTableAdd");
        //}


        [HttpPost]
        public async Task<IActionResult> Article(ArticleCreateDto dto)
        {


            await _articleService.CreateAsync(dto);

            return View("DesktopWindow");
        }

        public async Task<IActionResult> Add(string text)
        {
            ArticleCreateDto article = new ArticleCreateDto();
            article.Text = text;
            var Response = "";
            return Json(Response);
        }
    }
}
