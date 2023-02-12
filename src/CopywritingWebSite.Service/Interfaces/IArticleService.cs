using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.ArticleDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopywritingWebSite.Service.Interfaces
{
    public interface IArticleService
    {
        public Task CreateAsync(ArticleCreateDto dto);
        public Task UpdateAsync(long id, ArticleCreateDto dto);
        public Task DeleteAsync(long id);
        public Task<IEnumerable<Article>> GetAllAsync();
        public Task<IEnumerable<Article>> GetByIdAsync(long id);
    }
}
