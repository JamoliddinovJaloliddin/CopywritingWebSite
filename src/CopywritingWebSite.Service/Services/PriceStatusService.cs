using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.PriceStatusDto;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CopywritingWebSite.Service.Services
{
    public class PriceStatusService : IPriceStatusService
    {
        private readonly AppDbContext _appDbContext;

        public PriceStatusService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public async Task CreateAsync(PriceStatusCreateDto dto)
        {
            var priceStatus = (PriceStatus)dto;
            _appDbContext.PriceStatuses.Add(priceStatus);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var orderStatus = await _appDbContext.PriceStatuses.FindAsync(id);
            if (orderStatus is not null)
            {
                _appDbContext.PriceStatuses.Remove(orderStatus);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<PriceStatus>> GetAllAsync()
        {
            return await _appDbContext.PriceStatuses.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(long id, PriceStatusCreateDto dto)
        {
            var orderStatus = (PriceStatus)dto;
            orderStatus.Id = id;
            _appDbContext.PriceStatuses.Update(orderStatus);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
