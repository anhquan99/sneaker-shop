using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.ToTable("Discounts");
            builder.HasKey(x => x.Id); ;

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.DiscountPercent).IsRequired();  
            builder.Property(x => x.CreatedAt).IsRequired();
        }
    }
}
