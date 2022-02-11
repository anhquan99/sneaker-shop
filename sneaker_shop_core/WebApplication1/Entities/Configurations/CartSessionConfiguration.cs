using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class CartSessionConfiguration : IEntityTypeConfiguration<CartSession>
    {
        public void Configure(EntityTypeBuilder<CartSession> builder)
        {
            builder.ToTable("CartSessions");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Items).WithOne(x => x.Session)
                .HasForeignKey(x => x.CartSessionId); ;
            builder.HasOne(x => x.User).WithOne(x => x.CartSession)
                .HasForeignKey<CartSession>(x => x.UserId);

        }
    }
}
