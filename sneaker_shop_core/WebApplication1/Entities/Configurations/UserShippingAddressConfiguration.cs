using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class UserShippingAddressConfiguration : IEntityTypeConfiguration<UserShippingAddress>
    {
        public void Configure(EntityTypeBuilder<UserShippingAddress> builder)
        {
            builder.ToTable("UserShippingAddress");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasIndex(x => new { x.UserId, x.Address }).IsUnique();
            builder.HasOne(x => x.User).WithMany(x => x.shippingAddresses)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Country).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
        }
    }
}
