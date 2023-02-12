using CopywritingWebSite.Domain.Entities;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface ITermAccountService
    {
        public Task CreateAsync();
        public Task UpdateAsync(long id, TermAccount dto);
        public Task DeleteAsync(long id);
        public Task<IEnumerable<TermAccount>> GetAllAsync();
    }
}
