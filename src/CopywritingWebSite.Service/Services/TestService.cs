using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.TestDto;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CopywritingWebSite.Service.Services
{
    public class TestService : ITestService
    {
        private readonly AppDbContext _appDbContext;
        public TestService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task CraeteAsync(TestCreateDto dto)
        {
            var test = (Test)dto;
            _appDbContext.Tests.Add(test);
            await _appDbContext.SaveChangesAsync();
        }



        public async Task DeleteAsync(long id)
        {
            var test = await _appDbContext.Tests.FindAsync(id);
            _appDbContext.Tests.Remove(test);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Test>> GetAllAsync()
        {
            return await _appDbContext.Tests.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(long id, TestCreateDto dto)
        {
            var test = (Test)dto;
            test.Id = id;
            _appDbContext.Tests.Update(test);
            await _appDbContext.SaveChangesAsync();
        }


    }
}
