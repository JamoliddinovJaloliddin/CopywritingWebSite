using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.CustomerTheEmpolyeerDto;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface ICustomerTheEmpolyeerService
    {
        public Task CreateAsync(CustomerTheEmpolyeerCreateDto dto);
        public Task UpdateAsync(long id, CustomerTheEmpolyeerCreateDto dto);
        public Task DeleteAsync(long id);
        public Task<IEnumerable<CustomerTheEmpolyeer>> GetAllAsync();
        public Task<IEnumerable<CustomerTheEmpolyeer>> GetByIdAsync(long id);
    }
}
