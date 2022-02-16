using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class PaymentDetailConfiguration : IEntityTypeConfiguration<PaymentDetail>
    {
        public void Configure(EntityTypeBuilder<PaymentDetail> builder)
        {
            builder.ToTable("PaymentDetail");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.OrderId).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Method).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();

            builder.HasOne(x => x.Order).WithOne(x => x.PaymentDetail)
                .HasForeignKey<PaymentDetail>(x => x.OrderId);
        }
    }
}
