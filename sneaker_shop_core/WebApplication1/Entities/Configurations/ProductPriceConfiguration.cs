using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.ToTable("ProductPrices");
            builder.HasKey(x => new { x.ProductInventoryId, x.EffectTime });
            //builder.HasOne(x => x.ProductInventory).wi(x => x.Price)
            //    .HasForeignKey(x => x.ProductInventoryId); 
            
            builder.Property(x => x.ProductInventoryId).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.EffectTime).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
        }
    }
}
