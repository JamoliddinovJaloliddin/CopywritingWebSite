using CopywritingWebSite.Domain.Commons;

namespace CopywritingWebSite.Domain.Entities
{
    public class CustomerTheEmpolyeer : BaseEntity
    {
        public string CardNumber { get; set; } = String.Empty;
        public string CardMmYy { get; set; } = String.Empty;
        public double Amount { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; } = default!;

    }
}
