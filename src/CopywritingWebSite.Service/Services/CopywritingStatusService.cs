using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.CopywritingDto;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Services
{
    public class CopywritingStatusService : ICopywritingStatusService
    {
        private AppDbContext _appDbContext;

        public CopywritingStatusService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public async Task CraeteAsync(CopywritingCreateDto dto)
        {
            var status = (CopywritingStatus)dto;
            _appDbContext.CopywritingStatuses.Add(status);
            await _appDbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(long id)
        {
            var status = await _appDbContext.CopywritingStatuses.FindAsync(id);
            _appDbContext.CopywritingStatuses.Remove(status);
            await _appDbContext.SaveChangesAsync(); 
        }

        public async Task<IEnumerable<CopywritingStatus>> GetAllAsync()
        {
            return await _appDbContext.CopywritingStatuses.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(long id,CopywritingCreateDto dto)
        {
            var status = (CopywritingStatus)dto;
            status.Id = id;
            _appDbContext.CopywritingStatuses.Update(status);
            await _appDbContext.SaveChangesAsync(); 
        }
    }
}
