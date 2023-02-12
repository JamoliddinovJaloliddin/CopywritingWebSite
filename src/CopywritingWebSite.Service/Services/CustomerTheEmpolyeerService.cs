using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.CustomerTheEmpolyeerDto;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Services
{
    public class CustomerTheEmpolyeerService : ICustomerTheEmpolyeerService
    {
        private AppDbContext _appDbContext;

        public CustomerTheEmpolyeerService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task CreateAsync(CustomerTheEmpolyeerCreateDto dto)
        {
            var customer = (CustomerTheEmpolyeer)dto;
            customer.UserId = 1;
            customer.Amount = 0;
            _appDbContext.CustomerTheEmpolyeers.Add(customer);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var customer = await _appDbContext.CustomerTheEmpolyeers.FindAsync(id);
            if (customer is not null)
            {
                _appDbContext.Remove(customer);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CustomerTheEmpolyeer>> GetAllAsync()
        {
            return await _appDbContext.CustomerTheEmpolyeers.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<CustomerTheEmpolyeer>> GetByIdAsync(long id)
        {
            return await _appDbContext.CustomerTheEmpolyeers.Where(x => x.Id == id).AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(long id, CustomerTheEmpolyeerCreateDto dto)
        {
            var customer = (CustomerTheEmpolyeer)dto;
            customer.UserId = 1;
            customer.Amount = 0;
            _appDbContext.Update(customer);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
