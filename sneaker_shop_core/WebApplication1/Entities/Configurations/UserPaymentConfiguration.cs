using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class UserPaymentConfiguration : IEntityTypeConfiguration<UserPayment>
    {
        public void Configure(EntityTypeBuilder<UserPayment> builder)
        {
            builder.ToTable("UserPayments");
            builder.HasKey(x => new { x.AccountNumber, x.UserId });

            builder.HasOne(x => x.User).WithMany(x => x.userPayments)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.PaymentType).IsRequired();
        }
    }
}
