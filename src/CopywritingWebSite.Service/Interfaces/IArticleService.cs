using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Dtos.ArticleDto;

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
