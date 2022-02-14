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

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Wallpaper).IsRequired();
            builder.Property(x => x.Releasedate).IsRequired();
            builder.Property(x => x.Color).IsRequired();
            builder.Property(x => x.Category).IsRequired();
            builder.Property(x => x.UserType).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.BrandSilhouetteID).IsRequired();
        }
    }
}
