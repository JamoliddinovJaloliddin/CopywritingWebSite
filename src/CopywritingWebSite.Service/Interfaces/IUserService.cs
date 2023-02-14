using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface IUserService
    {
        public Task<bool> DeleteAsync(string email);
    }
}
