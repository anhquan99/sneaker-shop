using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class ProductInventoryConfiguration : IEntityTypeConfiguration<ProductInventory>
    {
        public void Configure(EntityTypeBuilder<ProductInventory> builder)
        {
            builder.ToTable("ProductInventory");
            builder.HasKey(x => new { x.Id });
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasIndex(x => new {x.ProductId, x.Size}).IsUnique();
        }
    }
}
