using CopywritingWebSite.Domain.Entities;

namespace CopywritingWebSite.Service.Dtos.CustomerWorkerDto
{
    public class CustomerWorkerCreateDto
    {
        public string CardNumber { get; set; } = String.Empty;
        public string CardMmYy { get; set; } = String.Empty;
        public static implicit operator CustomerWorker(CustomerWorkerCreateDto dto)
        {
            return new CustomerWorker()
            {
                CardNumber = dto.CardNumber,
                CardMmYy = dto.CardMmYy,
            };
        }
    }
}
