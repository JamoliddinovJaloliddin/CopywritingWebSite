using CopywritingWebSite.Domain.Commons;
using CopywritingWebSite.Domain.Enums;

namespace CopywritingWebSite.Domain.Entities
{
    public class TermAccount : BaseEntity
    {
        public long CustomerTheEmpolyeerId { get; set; }
        public virtual CustomerTheEmpolyeer CustomerTheEmpolyeer { get; set; } = default!;
        public long CustomerWorkerIdId { get; set; }
        public virtual CustomerWorker CustomerWorker { get; set; } = default!;
        public ArticleStatus ArticleStatus { get; set; }
        public bool Done { get; set; } = false;
        public double Price { get; set; }
    }
}
