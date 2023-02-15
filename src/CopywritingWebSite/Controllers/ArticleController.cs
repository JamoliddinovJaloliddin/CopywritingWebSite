using CopywritingWebSite.Service.Dtos.ArticleDto;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CopywritingWebSite.MVS.Controllers
{
    [Route("article")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            this._articleService = articleService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateAsync(string text)
        {
            ArticleCreateDto article = new ArticleCreateDto();
            article.Text = text;

            return Ok(_articleService.CreateAsync(article));
        }


    }
}
