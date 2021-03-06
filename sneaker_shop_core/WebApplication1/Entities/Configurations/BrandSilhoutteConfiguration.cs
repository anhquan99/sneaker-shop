using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class BrandSilhoutteConfiguration : IEntityTypeConfiguration<BrandSilhouette>
    {
        public void Configure(EntityTypeBuilder<BrandSilhouette> builder)
        {
            builder.ToTable("BrandSilhouttes");
            builder.HasKey(x => x.NameId);

            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.HasMany(x => x.Products).WithMany(x => x.BrandSilhouette);
        }
    }
}
