using CopywritingWebSite.Domain.Entities;

namespace CopywritingWebSite.Service.Dtos.PriceStatusDto
{
    public class PriceStatusCreateDto
    {
        public long CopyWritingStatusId { get; set; }
        public int CountSymbol { get; set; }
        public double Price { get; set; }


        public static implicit operator PriceStatus(PriceStatusCreateDto dto)
        {
            return new PriceStatus()
            {
                CopyWritingStatusId = dto.CopyWritingStatusId,
                CountSymbol = dto.CountSymbol,
                Price = dto.Price
            };
        }
    }
}
