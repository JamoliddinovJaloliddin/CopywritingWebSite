using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Service.Interfaces;
using CopywritingWebSite.Service.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _appDbContext;

        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> DeleteAsync(string email)
        {
            try
            {
                var res = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
                if (res is not null)
                {
                    _appDbContext.Users.Remove(res);
                    var resault = await _appDbContext.SaveChangesAsync();
                    GlobalVariableModel.Email = null;
                    return resault > 0;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
