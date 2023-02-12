using CopywritingWebSite.Domain.Entities;

namespace CopywritingWebSite.Service.Dtos.CustomerWorkerDto
{
    public class CustomerWorkerUpdateDto
    {
        public int Level { get; set; }
        public long UserId { get; set; }
        public double Price { get; set; } = default!;

        public static implicit operator CustomerWorker(CustomerWorkerUpdateDto dto)
        {
            return new CustomerWorker()
            {
                Level = dto.Level,
                UserId = dto.UserId,
                Price = dto.Price,
            };
        }
    }
}
