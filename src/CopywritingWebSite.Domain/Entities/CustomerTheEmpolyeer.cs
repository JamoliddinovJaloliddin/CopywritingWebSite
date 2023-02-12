using CopywritingWebSite.Domain.Commons;

namespace CopywritingWebSite.Domain.Entities
{
    public class CustomerTheEmpolyeer : BaseEntity
    {
        public string CardNumber { get; set; }
        public string CardMmYy { get; set; }
        public double Amount { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; } = default!;

    }
}
