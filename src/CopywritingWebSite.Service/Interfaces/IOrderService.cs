using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.OrderDto;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface IOrderService
    {
        public Task CreateAsync(OrderCreateDto dto);
        public Task UpdateAsync(long id);
        public Task DeleteAsync(long id);
        public Task<IEnumerable<Order>> GetAllAsync();
        public Task<IEnumerable<Order>> GetByIdAsync(long id);
    }
}
