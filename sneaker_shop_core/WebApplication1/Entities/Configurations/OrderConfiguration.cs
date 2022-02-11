﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Entities.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User).WithMany(x => x.orders).HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Items).WithOne(x => x.Order);
            builder.HasOne(x => x.PaymentDetail).WithOne(x => x.Order).HasForeignKey(x => x.OrderId);

        }
    }
}