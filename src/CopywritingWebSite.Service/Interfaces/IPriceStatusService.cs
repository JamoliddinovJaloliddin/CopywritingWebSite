using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.PriceStatusDto;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface IPriceStatusService
    {
        public Task CreateAsync(PriceStatusCreateDto dto);
        public Task UpdateAsync(long id, PriceStatusCreateDto dto);
        public Task DeleteAsync(long id);
        public Task<IEnumerable<PriceStatus>> GetAllAsync();
    }
}
