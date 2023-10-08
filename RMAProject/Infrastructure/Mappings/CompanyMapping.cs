using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMAProject.Domain.Entities;

namespace RMAProject.Infrastructure.Mappings
{
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(p => p.CPNJ).HasMaxLength(30);
            builder.Property(p => p.Email).HasMaxLength(100);
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.HasOne(a => a.Address).WithOne().HasForeignKey<Company>(a => a.AddressId);
        }
    }
}
