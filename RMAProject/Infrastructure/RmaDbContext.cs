using Microsoft.EntityFrameworkCore;

namespace RMAProject.Infrastructure
{
    public class RmaDbContext : DbContext
    {
        public RmaDbContext(DbContextOptions<RmaDbContext> options) : base(options) { }

        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
