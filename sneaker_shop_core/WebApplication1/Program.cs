using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;
using WebApplication1.Repository.Implements;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<User>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.SignIn.RequireConfirmedEmail = false;
        options.SignIn.RequireConfirmedPhoneNumber = false;
    })
    .AddRoles<IdentityRole<Guid>>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.Cookie.Name = "YourAppCookieName";
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.LoginPath = "/Identity/Account/Login";
    // ReturnUrlParameter requires
    //using Microsoft.AspNetCore.Authentication.Cookies;
    options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
    options.SlidingExpiration = true;
});


builder.Services.AddScoped<ICRUDRepository<BrandSilhouette, string>, BrandSilhouetteRepo>();
builder.Services.AddScoped<ICRUDRepository<CartItem, int>, CartItemRepo>();
builder.Services.AddScoped<ICRUDRepository<CartSession, int>, CartSessionRepo>();
builder.Services.AddScoped<ICRUDRepository<Discount, int>, DiscountRepo>();
builder.Services.AddScoped<ICRUDRepository<OrderItem, int>, OrderItemRepo>();
builder.Services.AddScoped<ICRUDRepository<Order, int>, OrderRepo>();
builder.Services.AddScoped<ICRUDRepository<PaymentDetail, int>, PaymentDetailRepo>();
builder.Services.AddScoped<ICRUDRepository<ProductImage, int>, ProductImageRepo>();
builder.Services.AddScoped<ICRUDRepository<ProductInventory, int>, ProductInventoryRepo>();
builder.Services.AddScoped<ICRUDRepository<ProductPrice, int>, ProductPriceRepo>();
builder.Services.AddScoped<IProductRepository, ProductRepo>();
builder.Services.AddScoped<ICRUDRepository<UserPayment, int>, UserPaymentRepo>();
builder.Services.AddScoped<ICRUDRepository<User, Guid>, UserRepo>();
builder.Services.AddScoped<ICRUDRepository<UserShippingAddress, Guid>, UserShippingAddressRepo>();
builder.Services.AddScoped<ICRUDRepository<WantedProduct, Guid>, WantedProductRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();