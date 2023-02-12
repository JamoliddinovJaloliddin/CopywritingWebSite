using CopywritingWebSite.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;


namespace CopywritingWebSite.MVS.Configurations.LayerConfiguration
{
    public static class DataAccessConfiguration
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DatabaseConnection");
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
           
        }
    }
}
