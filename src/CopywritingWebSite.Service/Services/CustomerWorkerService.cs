using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.CustomerWorkerDto;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CopywritingWebSite.Service.Services
{
    public class CustomerWorkerService : ICustomerWorkerService
    {
        private readonly AppDbContext _appDbContext;

        public CustomerWorkerService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task CreateAsync(CustomerWorkerCreateDto dto)
        {
            var customer = (CustomerWorker)dto;
            customer.Price = 0;
            customer.UserId = 1;
            customer.Level = 0;
            customer.CountTheWork = 0;

            _appDbContext.CustomerWorkers.Add(customer);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var customer = await _appDbContext.CustomerWorkers.FindAsync(id);
            if (customer is not null)
            {
                _appDbContext.Remove(customer);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CustomerWorker>> GetAllAsync()
        {
            return await _appDbContext.CustomerWorkers.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<CustomerWorker>> GetByIdAsync(long id)
        {
            return await _appDbContext.CustomerWorkers.Where(x => x.Id == id).AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(long id, CustomerWorkerUpdateDto dto)
        {
            var userCustomer = await _appDbContext.CustomerWorkers.FindAsync(id);
            var customer = (CustomerWorker)dto;
            userCustomer.Level += customer.Level;
            userCustomer.Price += customer.Price;
            userCustomer.Id = id;
            _appDbContext.CustomerWorkers.Update(userCustomer);
        }
    }
}
