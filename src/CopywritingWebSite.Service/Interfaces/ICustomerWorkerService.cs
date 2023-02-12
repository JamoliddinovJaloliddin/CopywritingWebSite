using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.CustomerWorkerDto;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface ICustomerWorkerService
    {
        public Task CreateAsync(CustomerWorkerCreateDto dto);
        public Task UpdateAsync(long id, CustomerWorkerUpdateDto dto);
        public Task DeleteAsync(long id);
        public Task<IEnumerable<CustomerWorker>> GetAllAsync();
        public Task<IEnumerable<CustomerWorker>> GetByIdAsync(long id);
    }
}
