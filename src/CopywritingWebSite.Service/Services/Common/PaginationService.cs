using CopywritingWebSite.Service.Common.Utils;
using CopywritingWebSite.Service.Interfaces.Common;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace CopywritingWebSite.Service.Services.Common
{
    public class PaginationService : IPaginationService
    {
        private readonly IHttpContextAccessor _accessor;

        public PaginationService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public async Task<IList<T>> ToPageAsync<T>(IList<T> items, int pageNumber, int pageSize)
        {
            int totalItems = items.Count;
            PaginationMetaData paginationMetaData = new PaginationMetaData(pageNumber, pageSize, totalItems)
            {
                CurrentPage = pageNumber,
                PageSize = pageSize,
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling((double)totalItems / (double)pageSize),
                HasPrevious = pageNumber > 1
            };

            paginationMetaData.HasNext = paginationMetaData.CurrentPage < paginationMetaData.TotalPages;

            string json = JsonConvert.SerializeObject(paginationMetaData);
            _accessor.HttpContext!.Response.Headers.Add("X-Pagination", json);

            return items.Skip(pageNumber * pageSize - pageSize).Take(pageSize).ToList();
        }
    }
}

