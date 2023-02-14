namespace CopywritingWebSite.Service.Interfaces.Common
{
    public interface IPaginationService
    {
        public Task<IList<T>> ToPageAsync<T>(IList<T> items, int pageNumber, int pageSize);
    }
}



