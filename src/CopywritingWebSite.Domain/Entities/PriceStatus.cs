using CopywritingWebSite.Domain.Commons;

namespace CopywritingWebSite.Domain.Entities
{
    public class PriceStatus : BaseEntity
    {
        public long CopyWritingStatusId { get; set; }
        public virtual CopywritingStatus CopyWritingStatus { get; set; } = default!;
        public int CountSymbol { get; set; }
        public double Price { get; set; }
    }
}
