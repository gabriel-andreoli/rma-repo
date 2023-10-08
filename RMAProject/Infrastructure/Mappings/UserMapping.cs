using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMAProject.Domain.Entities;

namespace RMAProject.Infrastructure.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(c => c.Company).WithMany(u => u.Users).HasForeignKey(c => c.CompanyId);
        }
    }
}
