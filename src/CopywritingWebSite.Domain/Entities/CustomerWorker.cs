using CopywritingWebSite.Domain.Commons;

namespace CopywritingWebSite.Domain.Entities
{
    public class CustomerWorker : BaseEntity
    {
        public int Level { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; } = default!;
        public int CountTheWork { get; set; } = default!;
        public string CardNumber { get; set; } = String.Empty;
        public string CardMmYy { get; set; } = String.Empty;
        public double Price { get; set; } = default!;
    }
}
