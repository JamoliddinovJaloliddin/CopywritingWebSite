using CopywritingWebSite.Domain.Commons;

namespace CopywritingWebSite.Service.ViewModels
{
    public class AdminWorkerModel : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int CountEmpolyee { get; set; }
    }
}
