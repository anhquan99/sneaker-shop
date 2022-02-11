using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            
            builder.HasOne(x => x.BrandSilhouette).WithMany(x => x.Products)
                .HasForeignKey(x => x.BrandSilhouetteID);
            builder.HasMany(x => x.ProductImages).WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.ProductInventory).WithOne(x => x.Product)
                .HasForeignKey<ProductInventory>(x => x.ProductId);
            builder.HasMany(x => x.OrderItems).WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);
            builder.HasMany(x => x.CardItems).WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            builder.HasMany(x => x.Discount).WithMany(x => x.Products);
            
        }
    }
}
