using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.CopywritingDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface ICopywritingStatusService
    {
        public Task CraeteAsync(CopywritingCreateDto dto);
        public Task UpdateAsync(long id, CopywritingCreateDto dto);
        public Task DeleteAsync(long id);
        public Task<IEnumerable<CopywritingStatus>> GetAllAsync();
    }
}
