using CopywritingWebSite.Domain.Commons;

namespace CopywritingWebSite.Domain.Entities
{
    public class Article : BaseEntity
    {
        public string ArticleText { get; set; } = string.Empty;
        public long UserId { get; set; }
        public virtual User User { get; set; } = default!;
    }
}
