using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.ToTable("CartItems");
            builder.HasKey(x => new { x.ProductId, x.CartSessionId });

            builder.HasOne(x => x.Product).WithMany(x => x.CardItems)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
