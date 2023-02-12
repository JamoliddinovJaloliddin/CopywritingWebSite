using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.TestDto;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface ITestService
    {
        public Task CraeteAsync(TestCreateDto dto);
        public Task UpdateAsync(long id, TestCreateDto dto);
        public Task DeleteAsync(long id);
        public Task<IEnumerable<Test>> GetAllAsync();
    }
}
