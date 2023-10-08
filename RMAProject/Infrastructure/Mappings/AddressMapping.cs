using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMAProject.Domain.Entities;

namespace RMAProject.Infrastructure.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(x => x.Country).HasMaxLength(40);
            builder.Property(x => x.State).HasMaxLength(40);
            builder.Property(x => x.City).HasMaxLength(40);
            builder.Property(x => x.Neighbour).HasMaxLength(40);
            builder.Property(x => x.Street).HasMaxLength(100);
            builder.Property(x => x.PostalCode).HasMaxLength(40);
            builder.Property(x => x.NumberAddress).HasMaxLength(15);
            builder.Property(x => x.Complement).HasMaxLength(40);
        }
    }
}
