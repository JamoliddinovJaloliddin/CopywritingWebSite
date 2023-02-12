using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Interfaces;

namespace CopywritingWebSite.Service.Services
{
    public class TermAccountService : ITermAccountService
    {
        private readonly AppDbContext _appDbContaxt;

        public TermAccountService(AppDbContext appDbContext)
        {
            this._appDbContaxt = appDbContext;
        }
        public async Task CreateAsync()
        {
            TermAccount termAccount = new TermAccount();
            termAccount.CustomerTheEmpolyeerId = 1;
            termAccount.CustomerWorkerIdId = 1;
            termAccount.ArticleStatus.ToString();
            termAccount.Done = false;
            termAccount.Price = 0;
            _appDbContaxt.TermAccounts.Add(termAccount);
            await _appDbContaxt.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var termAccount = await _appDbContaxt.TermAccounts.FindAsync(id);
            _appDbContaxt.TermAccounts.Remove(termAccount);
            await _appDbContaxt.SaveChangesAsync();

        }

        public Task<IEnumerable<Domain.Entities.TermAccount>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(long id, TermAccount dto)
        {
            var termAccount = await _appDbContaxt.TermAccounts.FindAsync(id);
            termAccount.Id = id;
            termAccount.ArticleStatus = dto.ArticleStatus;
            termAccount.Done = dto.Done;
            termAccount.Price = dto.Price;
            _appDbContaxt.TermAccounts.Update(termAccount);
            await _appDbContaxt.SaveChangesAsync();
        }
    }
}
