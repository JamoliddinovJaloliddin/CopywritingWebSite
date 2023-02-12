using CopywritingWebSite.Domain.Entities;

namespace CopywritingWebSite.Service.Dtos.CopywritingDto
{
    public class CopywritingCreateDto
    {
        public string Status { get; set; } = String.Empty;


        public static implicit operator CopywritingStatus(CopywritingCreateDto dto)
        {
            return new CopywritingStatus()
            {
                Status = dto.Status,
            };
        }
    }
}
