using CopywritingWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CopywritingWebSite.DataAccess.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Article> Articles { get; set; } = default!;
        public virtual DbSet<CopywritingStatus> CopywritingStatuses { get; set; } = default!;
        public virtual DbSet<CustomerTheEmpolyeer> CustomerTheEmpolyeers { get; set; } = default!;
        public virtual DbSet<CustomerWorker> CustomerWorkers { get; set; } = default!;
        public virtual DbSet<Order> Orders { get; set; } = default!;
        public virtual DbSet<PriceStatus> PriceStatuses { get; set; } = default!;
        public virtual DbSet<TermAccount> TermAccounts { get; set; } = default!;
        public virtual DbSet<Test> Tests { get; set; } = default!;
        public virtual DbSet<User> Users { get; set; } = default!;
    }
}


