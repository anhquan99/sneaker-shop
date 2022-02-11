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

        }
    }
}
