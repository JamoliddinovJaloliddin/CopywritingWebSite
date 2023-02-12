using CopywritingWebSite.DataAccess.DbContexts;
using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.ArticleDto;
using CopywritingWebSite.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Services
{
    public class ArticleText : IArticleText
    {
        private readonly AppDbContext _appDbContext;

        public ArticleText(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task CreateAsync(ArticleTextDto dto)
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

        public async Task UpdateAsync(long id, ArticleTextDto dto)
        {
            var text = (Article)dto;
            text.Id = id;
            _appDbContext.Articles.Update(text);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
