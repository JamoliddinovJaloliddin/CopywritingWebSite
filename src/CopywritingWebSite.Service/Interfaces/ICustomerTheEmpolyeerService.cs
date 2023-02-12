using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.CustomerTheEmpolyeerDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
