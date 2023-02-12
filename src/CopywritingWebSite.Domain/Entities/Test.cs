using CopywritingWebSite.Domain.Commons;
using CopywritingWebSite.Domain.Enums;

namespace CopywritingWebSite.Domain.Entities
{
    public class Test : BaseEntity
    {
        public LanguageStatus Status { get; set; }
        public string Question { get; set; } = String.Empty;
        public string ChooseOne { get; set; } = String.Empty;
        public string ChooseTwo { get; set; } = String.Empty;
        public string ChooseThree { get; set; } = String.Empty;
        public string Answer { get; set; } = String.Empty;
    }
}
