using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.ArticleDto;
using CopywritingWebSite.Service.Interfaces;
using CopywritingWebSite.Service.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CopywritingWebSite.Service.Services
{
    public class ArticleService : IArticleService
    {
        private readonly AppDbContext _appDbContext;
        private readonly List<string> strings = new List<string>() { "&lt;script&gt;", "&lt;/script&gt;" };

        public ArticleService(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<bool> CreateAsync(ArticleCreateDto dto)
        {
            string word = dto.Text;
            foreach (string s in strings)
            {
                bool resault = word.Contains(s);
                if (resault == true)
                {
                    return false;
                }
            }

            var text = (Article)dto;
            text.UserId = GlobalVariableModel.Id;
            _appDbContext.Articles.Add(text);
            var res = _appDbContext.SaveChanges();
            return res > 0;
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
