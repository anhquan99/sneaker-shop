using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class UserShippingAddressConfiguration : IEntityTypeConfiguration<UserShippingAddress>
    {
        public void Configure(EntityTypeBuilder<UserShippingAddress> builder)
        {
            builder.ToTable("UserShippingAddress");
            builder.HasKey(x => new {x.UserId, x.Address});

            builder.HasOne(x => x.User).WithMany(x => x.shippingAddresses)
                .HasForeignKey(x => x.UserId);
        }
    }
}
