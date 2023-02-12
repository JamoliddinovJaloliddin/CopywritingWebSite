using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Domain.Enums;

namespace CopywritingWebSite.Service.Dtos.OrderDto
{
    public class OrderCreateDto
    {
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public long CopywritingStatusId { get; set; }
        public LanguageStatus LanguageStatus { get; set; } = default!;
        public string AttachedFile { get; set; } = String.Empty;
        public string LifeTime { get; set; } = String.Empty;
        public CopyWrirtingLevel CopyWrirtingLevel { get; set; }
        public long PriceStatusId { get; set; }

        public static implicit operator Order(OrderCreateDto dto)
        {
            return new Order()
            {
                Title = dto.Title,
                Description = dto.Description,
                CopywritingStatusId = dto.CopywritingStatusId,
                LanguageStatus = dto.LanguageStatus,
                LifeTime = dto.LifeTime,
                CopyWrirtingLevel = dto.CopyWrirtingLevel,
                PriceStatusId = dto.PriceStatusId,
            };
        }
    }
}
