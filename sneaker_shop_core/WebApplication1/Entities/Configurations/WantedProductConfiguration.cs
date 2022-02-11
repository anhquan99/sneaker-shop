using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class WantedProductConfiguration : IEntityTypeConfiguration<WantedProduct>
    {
        public void Configure(EntityTypeBuilder<WantedProduct> builder)
        {
            builder.ToTable("WantedProducts");
            builder.HasKey(x => new {x.UserId, x.ProductId});

            builder.HasOne(x => x.Product).WithMany(x => x.WantedProducts)
                .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.User).WithMany(x => x.WantedProducts)
                .HasForeignKey(x => x.UserId);
        }
    }
}
