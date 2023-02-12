using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.ArticleDto;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CopywritingWebSite.Service.Services
{
    public class ArticleService : IArticleService
    {
        private readonly AppDbContext _appDbContext;

        public ArticleService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task CreateAsync(ArticleCreateDto dto)
        {
            var text = (Article)dto;
            _appDbContext.Articles.Add(text);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var text = await _appDbContext.Articles.FindAsync(id);
            _appDbContext.Articles.Remove(text);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Article>> GetAllAsync()
        {
            return await _appDbContext.Articles.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Article>> GetByIdAsync(long id)
        {
            return await _appDbContext.Articles.Where(x => x.Id == id).AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(long id, ArticleCreateDto dto)
        {
            var text = (Article)dto;
            text.Id = id;
            _appDbContext.Articles.Update(text);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
