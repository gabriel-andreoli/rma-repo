using Microsoft.EntityFrameworkCore;
using RMAProject.Domain.Entities;

namespace RMAProject.Infrastructure
{
    public class RmaDbContext : DbContext
    {
        public RmaDbContext(DbContextOptions<RmaDbContext> options) : base(options) { }

        public DbSet<Company> Company { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
