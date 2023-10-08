using Microsoft.EntityFrameworkCore;
using RMAProject.Domain.Entities;
using RMAProject.Infrastructure.Mappings;

namespace RMAProject.Infrastructure
{
    public class RmaDbContext : DbContext
    {
        public RmaDbContext(DbContextOptions<RmaDbContext> options) : base(options) { }
        public DbSet<Company> Company { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CompanyMapping().Configure(modelBuilder.Entity<Company>());
        }
    }
}
