using CopywritingWebSite.Domain.Entities;

namespace CopywritingWebSite.Service.Dtos.ArticleDto
{
    public class ArticleCreateDto
    {
        public string Text { get; set; } = String.Empty;

        public static implicit operator Article(ArticleCreateDto dto)
        {
            return new Article()
            {
                ArticleText = dto.Text,
            };
        }
    }
}
