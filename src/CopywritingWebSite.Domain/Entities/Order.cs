using CopywritingWebSite.Domain.Commons;
using CopywritingWebSite.Domain.Enums;

namespace CopywritingWebSite.Domain.Entities
{
    public class Order : BaseEntity
    {
        public long CustomerTheEmpolyeerId { get; set; }
        public virtual CustomerTheEmpolyeer CustomerTheEmpolyeer { get; set; } = default!;
        public long CustomerWorkerIdId { get; set; }
        public virtual CustomerWorker CustomerWorker { get; set; } = default!;
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public long CopywritingStatusId { get; set; }
        public virtual CopywritingStatus CopywritingStatus { get; set; } = default!;
        public LanguageStatus LanguageStatus { get; set; } = default!;
        public string AttachedFile { get; set; } = String.Empty;
        public string LifeTime { get; set; } = String.Empty;
        public CopyWrirtingLevel CopyWrirtingLevel { get; set; }
        public long PriceStatusId { get; set; }
        public virtual PriceStatus PriceStatus { get; set; } = default!;
        public string CreateAt { get; set; } = String.Empty;
        public bool ArticeStatus { get; set; }
    }
}
