using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.Acccount;
using CopywritingWebSite.Service.Helpers;
using CopywritingWebSite.Service.Interfaces;
using CopywritingWebSite.Service.Services.Common;
using Microsoft.EntityFrameworkCore;

namespace CopywritingWebSite.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _appDbContext;
        public AccountService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<string> LoginAsync(long id, AccountRegisterDto dto)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
            if (user is null)
            {
                return "";
            }

            var hashResault = PasswordHash.Verify(user.PasswordHash, user.Salt, user.PasswordHash);
            if (hashResault)
            {
                return "";
            }
            return "";
        }

        public async Task<string> RegisterAsync(AccountRegisterDto dto)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
            if (user is not null)
            {
                return "";
            }
            var passwordHash = PasswordHash.Hash(dto.Password);
            var users = (User)dto;
            users.Salt = passwordHash.Salt;
            users.PasswordHash = passwordHash.Hash;
            users.CreateAt = TimeHelper.GetCurrentServerTime().ToString();
            _appDbContext.Users.Add(users);
            await _appDbContext.SaveChangesAsync();
            return "";
        }
    }
}
