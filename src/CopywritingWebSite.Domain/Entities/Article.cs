using CopywritingWebSite.Domain.Commons;

namespace CopywritingWebSite.Domain.Entities
{
    public class Article : BaseEntity
    {
        public string ArticleText { get; set; } = string.Empty;
    }
}
