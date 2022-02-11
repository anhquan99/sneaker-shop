using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;
using WebApplication1.Entities.Configurations;
//using WebApplication1.Entities.Configurations;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BrandSilhouette> brandSilhouettes { get; set; }
        public DbSet<CartItem> cartItems { get; set; }  
        public DbSet<CartSession> cartSessions { get; set; }    
        public DbSet<Discount> discounts { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<PaymentDetail> paymentDetails { get; set; }    
        public DbSet<Product>products { get; set; }
        public DbSet<ProductImage> productsImage { get; set; }  
        public DbSet<ProductInventory> productsInventory { get; set; }  
        public DbSet<ProductPrice> productsPrice { get; set; }
        public DbSet<UserPayment> userPayments { get; set; }
        public DbSet<UserShippingAddress> userShippingAddresses { get; set; }
        public DbSet<WantedProduct> wantedProducts { get; set; }    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new BrandSilhoutteConfiguration());
            builder.ApplyConfiguration(new CartItemConfiguration());
            builder.ApplyConfiguration(new CartSessionConfiguration());
            builder.ApplyConfiguration(new DiscountConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderItemConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ProductImageConfiguration());
            builder.ApplyConfiguration(new ProductInventoryConfiguration());
            builder.ApplyConfiguration(new ProductPriceConfiguration());
            builder.ApplyConfiguration(new UserPaymentConfiguration());
            builder.ApplyConfiguration(new UserShippingAddressConfiguration());
            builder.ApplyConfiguration(new WantedProductConfiguration());
        }
    }
}