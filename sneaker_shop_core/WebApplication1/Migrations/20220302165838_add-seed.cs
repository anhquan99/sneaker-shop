using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class addseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrandSilhouttes",
                columns: table => new
                {
                    NameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Story = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandSilhouttes", x => x.NameId);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountPercent = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "paymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wallpaper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Releasedate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrandSilhouetteID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_BrandSilhouttes_BrandSilhouetteID",
                        column: x => x.BrandSilhouetteID,
                        principalTable: "BrandSilhouttes",
                        principalColumn: "NameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscountProduct",
                columns: table => new
                {
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountProduct", x => new { x.DiscountId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_DiscountProduct_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => new { x.ProductId, x.Image });
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiledAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInventory_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrices",
                columns: table => new
                {
                    ProductInventoryId = table.Column<int>(type: "int", nullable: false),
                    EffectTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrices", x => new { x.ProductInventoryId, x.EffectTime });
                    table.ForeignKey(
                        name: "FK_ProductPrices_ProductInventory_ProductInventoryId",
                        column: x => x.ProductInventoryId,
                        principalTable: "ProductInventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartSessionId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartSessions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    PaymentDetailId = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_paymentDetails_PaymentDetailId",
                        column: x => x.PaymentDetailId,
                        principalTable: "paymentDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPayments",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expiry = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPayments", x => new { x.AccountNumber, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserPayments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserShippingAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserShippingAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserShippingAddress_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WantedProducts",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WantedProducts", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_WantedProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WantedProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartSessionId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.ProductId, x.CartSessionId });
                    table.ForeignKey(
                        name: "FK_CartItems_CartSessions_CartSessionId",
                        column: x => x.CartSessionId,
                        principalTable: "CartSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"), "40ea5d74-d817-4946-8e5c-686e914ff1ac", "admin", "admin" },
                    { new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"), "8f3b9fe6-30e9-4059-8cce-9b41d6a40ea8", "SuperAdmin", "superadmin" },
                    { new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"), "2a7d7876-8a4a-4f0d-b431-a08e27065872", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CartSessionId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"), 0, null, "75b07713-cf07-4338-97db-b24629a7920f", "superadmin@superadmin.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEACW2JN9xFmmHGdFhXqeyssshykwjxBk0K1teNCIKlbgpjavjvPvEWdEUtw5La4w+g==", null, false, "32b4c956-ffdc-452b-b67a-ea266fe3d4d7", false, "superAdmin" },
                    { new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"), 0, null, "dd852cc4-6004-4d1a-a0fe-8f33dc47d3e8", "admin@admin.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJynlQWTRYDpdA6NvWnQ4gBtU9CcZvGrqGNsH492HH9DRSwGp1K80MdyXjV3AJEJvw==", null, false, "e7ba0df3-d74a-4213-9ca3-9ce2bbd12687", false, "admin" },
                    { new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"), 0, null, "c1515f13-ccb6-4b84-8584-c0ceb53b851e", "customer1@customer1.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEN3MpoyaWjA3L0L7v3zTaQK5ON1lzJCyIxam3MpXvNs4AyzAJ58OT97AviVHzCRadw==", null, false, "c5e76584-2b29-474c-8caf-952ae78c17d2", false, "customer1" },
                    { new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"), 0, null, "7d92b731-6c5f-4b97-9de1-89f0f9e7570f", "user@user.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJHTHfuMjEq80eL5SMglT18kBjDNm5RN72v0SHGbYHx3WLdILhwLWgvX6+4gCzcVEw==", null, false, "e957887c-b0b3-49a7-bea5-2d2f3a12ddea", false, "defaultuser" },
                    { new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"), 0, null, "2e4d8735-6ed8-430c-80f8-d6592fac2352", "customer3@customer3.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJXnnWmLVmCPkl//GTHoHwEZwkZ+IGtYZakAWI0bkwW+sv5uYxFdJ+0tpQ5vBi6/gg==", null, false, "372cbc7e-38b3-4873-acb7-05019e9dd6dd", false, "customer3" },
                    { new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"), 0, null, "1537bfd4-9e3e-4115-8fbe-a57bc0257f6a", "customer2@customer2.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEPwSBF+olHKBuqcxw9nFJ2RrvIjjEJMyBHcEswA/yalmCxY8Rt5syltMsH596J0eTg==", null, false, "cde366bc-072b-4e3a-80c2-62cd8d85a747", false, "customer2" }
                });

            migrationBuilder.InsertData(
                table: "BrandSilhouttes",
                columns: new[] { "NameId", "CreatedAt", "Icon", "ModifiedAt", "Story" },
                values: new object[,]
                {
                    { "Adidas", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(117), "adidas.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adi Dassler founded adidas in 1949 in Herzogenaurach, Germany. Building on the reputation of the brand’s spiked running shoes and football cleats, Dassler turned adidas into a global icon, redefining sneakers and apparel in the process. Today, adidas is considered one of the world’s most influential brands, responsible for the Stan Smith, Yeezy sneakers and more." },
                    { "Air Jordan", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(127), "jordan.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In 1984, Nike unveiled the Air Jordan 1, a basketball sneaker designed by Peter Moore for a young Michael Jordan. The iconic silhouette transcended sneakers and sports, altering the trajectory of style forever. Today, Michael Jordan’s namesake brand continues to inspire sportswear and style movements around the world through new releases, retro drops and unexpected collaborations." },
                    { "Fear of God Essentials", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(129), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In 2018, Jerry Lorenzo launched Fear of God Essentials, a pared-back version of Fear of God. Each seasonal collection brings the line’s concept into sharper focus, uniting elevated sportswear basics with subdued shades and minimal branding." },
                    { "Nike", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(126), "nike.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Founded by Bill Bowerman and Phil Knight in 1964, Nike is synonymous with performance and innovation. Alongside its apparel offerings, the sportswear giant is responsible for a number of iconic sneakers, including the Air Force 1, the Air Max franchise and more. Today, Nike is among the world’s most recognized brands, identified by its wordmark and Swoosh logo." },
                    { "Supreme", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(127), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Founded by James Jebbia in 1994, Supreme is a New York-based skate brand known for its subcultural references and controversial graphics. Today, Supreme is considered one of style’s most influential voices, blurring the lines between streetwear and luxury through collaborations with artists, fashion houses and sneaker brands." },
                    { "Yeezy", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(128), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In late 2013, Kanye West and adidas announced their forthcoming partnership. In 2015, the two delivered on this news, arriving in the form of Yeezy Season 1, a collection of sneakers and apparel debuted at New York Fashion Week. Since the first collection, Yeezy has influenced style movements worldwide." }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"), new Guid("096149b4-92aa-4d5f-89ab-579244023ae6") },
                    { new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"), new Guid("218a643e-c736-4680-b8fc-6464f3e4b963") },
                    { new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"), new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088") },
                    { new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"), new Guid("f408ea82-601a-4573-9a68-c0e31fd87623") },
                    { new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"), new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandSilhouetteID", "Category", "Color", "CoverImage", "CreatedAt", "Description", "ModifiedAt", "Name", "Releasedate", "Type", "UserType", "Wallpaper" },
                values: new object[,]
                {
                    { 1, "Yeezy", "Boots", "Tan", "yeezy-boost-700-mauve-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(306), "The adidas Yeezy Boost 700 V2 ‘Mauve’ brings back a popular colorway first seen on a Yeezy Boost 700 release from 2018. The sneaker’s titular hue is executed on a textured mesh upper with arcing no-sew skins along the quarter panel and greenish-grey suede overlays throughout. Responsive cushioning comes courtesy of a full-length drop-in Boost midsole, housed within a sculpted polyurethane carrier. Underfoot, a herringbone-traction rubber outsole provides optimal grip.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Boost 700 V2 'Mauve'", new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 2, "Yeezy", "LifeStyle", "Sulfur", "yeezy-knit-runner-sulfur-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(666), "The adidas Yeezy Knit Runner ‘Sulfur’ delivers the debut colorway of Kanye West’s sock-like silhouette, which launched exclusively through the artist’s Yeezy Supply site. The fully knit build, rendered in a neutral tan shade with a contrasting mustard yellow finish throughout the majority of the upper, utilizes slip-on construction devoid of exterior branding. Embellishments are limited to sizing information stamped on the lateral collar. The sneaker rides on a durable rubber outsole in a matching yellow finish, featuring a modified herringbone tread and adidas branding under the heel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Knit Runner 'Sulfur'", new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 3, "Yeezy", "LifeStyle", "Yellow", "yeezy-foam-runner-ochre-1.jpg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(755), "The adidas Yeezy Foam Runner ‘Ochre’ complements its futuristic aesthetic with a subdued, monochromatic finish. A dark beige hue suffuses the one-piece foam build, featuring ventilation ports of varying shapes and dimensions that enhance breathability while adding depth to the slip-on’s flowing lines. ‘FOAM RNNR’ is debossed on the interior collar, alongside the shoe size and ‘Made in USA’ branding. Underfoot, the outsole features a wavy traction pattern for reliable grip.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Foam Runner 'Ochre'", new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 4, "Yeezy", "LifeStyle", "Black", "yeezy-450-dark-slate-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(805), "The adidas Yeezy 450 ‘Dark Slate’ delivers a blacked-out iteration of Kanye West’s boundary-pushing silhouette. Stripped of color and exterior branding, the knit upper is secured with an integrated lacing system and topped with an elastic, sock-like cuff. In lieu of a traditional midsole, the rubber outsole sprouts tapered appendages that wrap up the heel and side panels of the deconstructed build, providing support and enhanced durability within its grasp.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy 450 'Dark Slate'", new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 5, "Yeezy", "LifeStyle", "Black", "Yeezy-Boost-350-V2-Mono-Cinder-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(854), "Launching as part of a four-piece ‘Mono’ pack, the adidas Yeezy Boost 350 V2 ‘Mono Cinder’ applies a black-out finish to the lifestyle sneaker. The revised design features an upper crafted from monofilament mesh, reinforced with an interior cage and accented with a tonal lateral side stripe. A webbing pull tab at the heel allows the sock-like build to be easily slipped on and off. The stealthy palette extends to the midsole, featuring wrapped Boost cushioning that runs the length of the rubber outsole. This shoe released exclusively on Yeezy Supply.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Boost 350 V2 'Mono Cinder'", new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 6, "Air Jordan", "LifeStyle", "Blue", "air-jordan-1-retro-high-og-university-blue-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(945), "The Air Jordan 1 Retro High OG ‘University Blue’ makes use of a familiar palette that gives the nod to Michael Jordan’s UNC alma mater. The all-leather upper features a white base with powder blue overlays and a black signature Swoosh. Matching black accents make their way to the collar, tongue tag and printed Wings logo on the lateral collar flap. A brighter shade of blue is applied to the standard AJ1 outsole, featuring multi-directional traction and a pivot point under the forefoot.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 1 Retro High OG 'University Blue'", new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 7, "Air Jordan", "LifeStyle", "Yellow", "air-jordan-4-retro-lightning-2021-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(993), "The 2021 edition of the Air Jordan 4 Retro ‘Lightning’ resurrects a highly coveted colorway that originally launched in 2006 alongside an accompanying ‘Thunder’ colorway, both of which were inspired by Michael Jordan’s Motorsports team. A bright yellow hue floods the nubuck upper, contrasted by black netting and dark grey structural wings. Matching grey accents land on the woven tongue tag, interior tongue and Jumpman branding at the heel. A white PU midsole, enhanced with visible Air sole cushioning, rides on a dark grey herringbone rubber outsole.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 4 Retro 'Lightning' 2021'", new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 8, "Air Jordan", "LifeStyle", "Red", "air-jordan-5-retro-gs-raging-bull-2021-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1041), "The 2021 reissue of the Air Jordan 5 Retro ‘Raging Bull’ brings back a beloved colorway originally released as one-half of 2009’s Air Jordan 5 Raging Bulls Pack. The shoe’s defining feature is a plush Varsity Red suede upper, equipped with black eyelets and a Jumpman-branded reflective silver tongue. The heel overlay displays a second Jumpman logo and an embroidered 23 on the lateral side. A visible Nike Air heel unit enhances the polyurethane midsole, accented with red-tipped shark tooth detailing and supported by an icy translucent outsole.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 5 Retro 'Raging Bull' 2021'", new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 9, "Air Jordan", "LifeStyle", "Red", "air-jordan-11-retro-bred-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1089), "The Air Jordan 11 Retro 'Bred' 2019 brings back an original colorway initially debuted in 1995. The Tinker Hatfield-designed silhouette features Chicago Bulls colors, with black mesh on the upper sitting atop shiny black patent leather. A white midsole melds nicely with a translucent Varsity Red outsole, and is the same colorway that Michael Jordan wore during the 1996 NBA championship playoff run. This retro was distributed in December 2019 with OG detailing, including high-cut patent leather, signature Jumpman branding and MJ's number 23 stamped on the heel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 11 Retro 'Bred' 2019", new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 10, "Air Jordan", "LifeStyle", "Green", "air-jordan-1-retro-high-og-ps-seafoam-1", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1136), "Crafted for little kids, the Air Jordan 1 Retro High OG PS ‘Seafoam’ updates the iconic silhouette with a two-tone palette geared for the warm weather months. The upper is constructed from clean white leather with contrasting nubuck overlays in a pale green finish. The same pastel hue is repeated on the signature Swoosh, Nike branded tongue tag and durable rubber outsole. Woven white laces are outlined in reddish bronze for an unexpected pop of contrasting color.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " ", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Youth", null },
                    { 11, "Air Jordan", "LifeStyle", "Blue", "air-jordan-1-retro-high-og-dark-marina-blue-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1208), "The Air Jordan 1 Retro High OG ‘Dark Marina Blue’ dresses the iconic silhouette in classic two-tone color blocking. The all-leather upper features a black base with contrasting dark blue overlays along the forefoot, heel, collar and eyestay. A matching blue Swoosh is accompanied by a Jordan Wings logo stamped in black on the lateral collar flap. Atop the nylon tongue, a woven Nike Air tag nods to the shoe’s retro cushioning technology: an Air-sole unit encapsulated in polyurethane nestled in the heel of the rubber cupsole.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 1 Retro High OG 'Dark Marina Blue'", new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 12, "Air Jordan", "LifeStyle", "Tan", "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1257), "The stash pouch makes a repeat appearance on the lateral collar, while new zippered detailing is added to the medial side. Mismatched Nike Air and Cactus Jack branding adorns the heel of the left and right shoe, with additional graphics on the midsole, outsole, tongue and lace lock.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis Scott x Air Jordan 6 Retro 'British Khaki'", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 13, "Adidas", "Running", "Black", "Ultra-4D-OG-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1304), "The adidas Ultra 4D ‘OG’ borrows a familiar color scheme initially featured on the UltraBoost release from 2015. This pair replaces the signature Boost cushioning of the original with a futuristic adidas 4D midsole, using a lattice structure made with a blend of liquid resin, light and oxygen. Up top, a matching black knit build is reinforced with a tonal midfoot cage and contrasting purple heel counter marked with Ultra 4D branding.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'OG'", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 14, "Adidas", "Running", "Black", "ultra-4d-5-0-carbon-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1410), "The adidas Ultra 4D 5.0 ‘Carbon’ delivers a monotone take on a performance runner built on the brand’s revolutionary 3D-printed midsole, featuring a unique lattice structure crafted from a blend of light, oxygen and liquid resin. Up top, breathable Primeknit weaves together black and grey fibers to create unique patterns around the toe box and collar. Three-stripe branding is integrated into the midfoot cage, which works in tandem with a molded heel counter to provide added stability and support.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 5.0 'Carbon'", new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 15, "Adidas", "Running", "Grey", "ultra-4d-grey-pink-gradient-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1459), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'Grey Pink Gradient'", new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 16, "Adidas", "Running", "White", "Ultra-4D-Chalk-White-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1507), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'Chalk White'", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 17, "Adidas", "Running", "Cream", "ultra-4d-lemon-twist.png", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1554), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'Lemon Twist'", new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 18, "Nike", "Basketball", "Cream", "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1602), "Designed in partnership with the influential Tokyo-based retailer, the atmos x Nike LeBron 18 Low ‘Cherry Blossom’ showcases a spring-ready design, highlighted by a Swoosh formed with pink embroidered florals. The pastel hue is repeated on the sneaker’s molded eyelets and TPU heel counter, as well as a multicolor geometric print that enlivens the textile upper. The low-top sits on a cushy React foam midsole with a large-volume Max Air unit nestled under the heel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "atmos x LeBron 18 Low 'Sakura'", new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 19, "Nike", "Basketball", "Orange", "Little-Posite-One-GS-Twilight-Pulse-1.png", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1676), "The Nike Little Posite One GS ‘Twilight Pulse’ dresses Penny Hardaway’s signature shoe with a matte black finish on the molded synthetic upper. Metallic blue accents deliver contrasting color on the eyestay and collar trim, as does the bright orange shank plate integrated into the translucent sole unit. A mesh tongue and heel inlay provide breathable comfort while the attached pull loops are included for easy on and off.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little Posite One GS 'Twilight Pulse'", new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Youth", null },
                    { 20, "Nike", "Basketball", "Blue", "little-posite-one-xx-royal-1.png", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1724), "Nike released a grade school exclusive to celebrate the 20th-anniversary of the Nike Air Foamposite One. The Little Posite One XX GS 'Royal' features a shiny Royal Blue Foamposite shell with black suede details on the eyestay and collar. The sneaker also boasts a carbon fiber midfoot arch, a mini white Swoosh on the forefoot, an icy blue translucent outsole, and a mesh inner sleeve for breathability and comfort.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little Posite One XX GS 'Royal'", new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Youth", null },
                    { 21, "Nike", "Basketball", "White", "kyrie-5-ep-have-a-nike-day-1.png", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1773), "A special edition of Kyrie Irving’s fifth model in his signature line, the Nike Kyrie 5 basketball shoe was one of the sneakers selected to be part of Nike’s celebratory 'Have A Nike Day' collection. Released in June 2019, the shoe is comprised of an engineered mesh upper for breathable, natural movement. The exterior is fitted with denim overlays, multicolored accents and Nike’s retro smiley face logo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyrie 5 'Have A Nike Day'", new DateTime(2019, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 22, "Nike", "Basketball", "White", "zoom-kd-12-wolf-grey-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1876), "Doused in a 'Wolf Grey' colorway, the July 2019 Nike's Zoom KD 12 features a breathable and lightweight mesh upper with Flywire for lock-down, emulating the 'worn-in' feel NBA star Kevin Durant prefers. The shoe eliminates the more-typical strobel layer between the upper by stitching an iridescent, full-length Zoom Air unit directly to the upper increasing energy-return and spring on the court.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zoom KD 12 'Wolf Grey'", new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 23, "Supreme", "Outerwear", "Red", "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1932), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x The North Face Faux Fur Nuptse Jacket 'Red'", new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 24, "Supreme", "Outerwear", "Red", "supreme-x-nike-half-zip-hooded-sweatshirt-white-2.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2052), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x Nike Half Zip Hooded Sweatshirt 'White'", new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 25, "Supreme", "Outerwear", "Multi-Color", "supreme-saint-michael-fleece-jacket-white-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2102), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme Saint Michael Fleece Jacket 'White'", new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 26, "Supreme", "Outerwear", "Gold", "supreme-x-the-north-face-cargo-jacket-gold.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2150), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x The North Face Cargo Jacket 'Gold'", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 27, "Supreme", "Outerwear", "Black", "supreme-x-the-north-face-s-logo-mountain-jacket-black-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2197), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x The North Face S Logo Mountain Jacket 'Black'", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 28, "Fear of God Essentials", "Tops", "Black", "fear-of-god-essentials-kids-short-sleeve-polo-stretch-limo.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2244), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids Short-Sleeve Polo 'Stretch Limo'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 29, "Fear of God Essentials", "Outerwear", "Black", "fear-of-god-essentials-kids-pullover-hoodie-stretch-limo.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2315), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids Pullover Hoodie 'Stretch Limo'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 30, "Fear of God Essentials", "Bottoms", "Black", "fear-of-god-essentials-kids-sweatpant-stretch-limo.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2403), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids Sweatpant 'Stretch Limo'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 31, "Fear of God Essentials", "Accessories", "Brown", "fear-of-god-essentials-rc-9fifty-cap-black-1.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2472), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials RC 9FIFTY Cap 'Black'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 32, "Supreme", "Outerwear", "Fear of God Essentials", "fear-of-god-essentials-x-mr-porter-exclusive-hoodie-vicunia.jpeg", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2543), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids x Mr. Porter Exclusive Hoodie 'Vicunia'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[,]
                {
                    { "yeezy-boost-700-mauve-1.jpeg", 1 },
                    { "yeezy-boost-700-mauve-2.jpeg", 1 },
                    { "yeezy-boost-700-mauve-3.jpeg", 1 },
                    { "yeezy-boost-700-mauve-4.jpeg", 1 },
                    { "yeezy-boost-700-mauve-5.jpeg", 1 },
                    { "yeezy-boost-700-mauve-6.jpeg", 1 },
                    { "yeezy-boost-700-mauve-7.jpeg", 1 },
                    { "yeezy-boost-700-mauve-8.jpeg", 1 },
                    { "yeezy-knit-runner-sulfur-1.jpeg", 2 },
                    { "yeezy-knit-runner-sulfur-10.jpeg", 2 },
                    { "yeezy-knit-runner-sulfur-2.jpeg", 2 },
                    { "yeezy-knit-runner-sulfur-3.jpeg", 2 },
                    { "yeezy-knit-runner-sulfur-4.jpeg", 2 },
                    { "yeezy-knit-runner-sulfur-5.jpeg", 2 },
                    { "yeezy-knit-runner-sulfur-6.jpeg", 2 },
                    { "yeezy-knit-runner-sulfur-7.jpeg", 2 },
                    { "yeezy-knit-runner-sulfur-8.jpeg", 2 },
                    { "yeezy-knit-runner-sulfur-9.jpeg", 2 },
                    { "yeezy-foam-runner-ochre-1.jpg", 3 },
                    { "yeezy-foam-runner-ochre-2.jpg", 3 },
                    { "yeezy-foam-runner-ochre-3.jpg", 3 },
                    { "yeezy-foam-runner-ochre-4.jpg", 3 },
                    { "yeezy-foam-runner-ochre-5.jpg", 3 },
                    { "yeezy-foam-runner-ochre-6.jpg", 3 },
                    { "yeezy-foam-runner-ochre-7.jpg", 3 },
                    { "yeezy-foam-runner-ochre-8.jpg", 3 },
                    { "yeezy-450-dark-slate-1.jpeg", 4 },
                    { "yeezy-450-dark-slate-10.jpeg", 4 },
                    { "yeezy-450-dark-slate-2.jpeg", 4 },
                    { "yeezy-450-dark-slate-3.jpeg", 4 },
                    { "yeezy-450-dark-slate-4.jpeg", 4 },
                    { "yeezy-450-dark-slate-5.jpeg", 4 },
                    { "yeezy-450-dark-slate-6.jpeg", 4 },
                    { "yeezy-450-dark-slate-7.jpeg", 4 },
                    { "yeezy-450-dark-slate-8.jpeg", 4 },
                    { "yeezy-450-dark-slate-9.jpeg", 4 },
                    { "Yeezy-Boost-350-V2-Mono-Cinder-1.jpeg", 5 },
                    { "Yeezy-Boost-350-V2-Mono-Cinder-10.jpeg", 5 },
                    { "Yeezy-Boost-350-V2-Mono-Cinder-2.jpeg", 5 },
                    { "Yeezy-Boost-350-V2-Mono-Cinder-3.jpeg", 5 },
                    { "Yeezy-Boost-350-V2-Mono-Cinder-4.jpeg", 5 },
                    { "Yeezy-Boost-350-V2-Mono-Cinder-5.jpeg", 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[,]
                {
                    { "Yeezy-Boost-350-V2-Mono-Cinder-6.jpeg", 5 },
                    { "Yeezy-Boost-350-V2-Mono-Cinder-7.jpeg", 5 },
                    { "Yeezy-Boost-350-V2-Mono-Cinder-8.jpeg", 5 },
                    { "Yeezy-Boost-350-V2-Mono-Cinder-9.jpeg", 5 },
                    { "air-jordan-1-retro-high-og-university-blue-1.jpeg", 6 },
                    { "air-jordan-1-retro-high-og-university-blue-2.jpeg", 6 },
                    { "air-jordan-1-retro-high-og-university-blue-3.jpeg", 6 },
                    { "air-jordan-1-retro-high-og-university-blue-4.jpeg", 6 },
                    { "air-jordan-1-retro-high-og-university-blue-5.jpeg", 6 },
                    { "air-jordan-1-retro-high-og-university-blue-6.jpeg", 6 },
                    { "air-jordan-1-retro-high-og-university-blue-7.jpeg", 6 },
                    { "air-jordan-1-retro-high-og-university-blue-8.jpeg", 6 },
                    { "air-jordan-4-retro-lightning-2021-1.jpeg", 7 },
                    { "air-jordan-4-retro-lightning-2021-2.jpeg", 7 },
                    { "air-jordan-4-retro-lightning-2021-3.jpeg", 7 },
                    { "air-jordan-4-retro-lightning-2021-4.jpeg", 7 },
                    { "air-jordan-4-retro-lightning-2021-5.jpeg", 7 },
                    { "air-jordan-4-retro-lightning-2021-6.jpeg", 7 },
                    { "air-jordan-4-retro-lightning-2021-7.jpeg", 7 },
                    { "air-jordan-4-retro-lightning-2021-8.jpeg", 7 },
                    { "air-jordan-5-retro-gs-raging-bull-2021-1.jpeg", 8 },
                    { "air-jordan-5-retro-gs-raging-bull-2021-2.jpeg", 8 },
                    { "air-jordan-5-retro-gs-raging-bull-2021-3.jpeg", 8 },
                    { "air-jordan-5-retro-gs-raging-bull-2021-4.jpeg", 8 },
                    { "air-jordan-5-retro-gs-raging-bull-2021-5.jpeg", 8 },
                    { "air-jordan-5-retro-gs-raging-bull-2021-6.jpeg", 8 },
                    { "air-jordan-5-retro-gs-raging-bull-2021-7.jpeg", 8 },
                    { "air-jordan-5-retro-gs-raging-bull-2021-8.jpeg", 8 },
                    { "air-jordan-11-retro-bred-1.jpeg", 9 },
                    { "air-jordan-11-retro-bred-2.jpeg", 9 },
                    { "air-jordan-11-retro-bred-3.jpeg", 9 },
                    { "air-jordan-11-retro-bred-4.jpeg", 9 },
                    { "air-jordan-11-retro-bred-5.jpeg", 9 },
                    { "air-jordan-11-retro-bred-6.jpeg", 9 },
                    { "air-jordan-11-retro-bred-7.jpeg", 9 },
                    { "air-jordan-11-retro-bred-8.jpeg", 9 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-1", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-2", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-3", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-4", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-5", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-6", 10 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[,]
                {
                    { "air-jordan-1-retro-high-og-ps-seafoam-7", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-8", 10 },
                    { "air-jordan-1-retro-high-og-dark-marina-blue-1.jpeg", 11 },
                    { "air-jordan-1-retro-high-og-dark-marina-blue-2.jpeg", 11 },
                    { "air-jordan-1-retro-high-og-dark-marina-blue-3.jpeg", 11 },
                    { "air-jordan-1-retro-high-og-dark-marina-blue-4.jpeg", 11 },
                    { "air-jordan-1-retro-high-og-dark-marina-blue-5.jpeg", 11 },
                    { "air-jordan-1-retro-high-og-dark-marina-blue-6.jpeg", 11 },
                    { "air-jordan-1-retro-high-og-dark-marina-blue-7.jpeg", 11 },
                    { "air-jordan-1-retro-high-og-dark-marina-blue-8.jpeg", 11 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-1.jpeg", 12 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-10.jpeg", 12 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-2.jpeg", 12 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-3.jpeg", 12 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-4.jpeg", 12 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-5.jpeg", 12 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-6.jpeg", 12 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-7.jpeg", 12 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-8.jpeg", 12 },
                    { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-9.jpeg", 12 },
                    { "Ultra-4D-OG-1.jpeg", 13 },
                    { "Ultra-4D-OG-2.jpeg", 13 },
                    { "Ultra-4D-OG-3.jpeg", 13 },
                    { "Ultra-4D-OG-4.jpeg", 13 },
                    { "Ultra-4D-OG-5.jpeg", 13 },
                    { "Ultra-4D-OG-6.jpeg", 13 },
                    { "Ultra-4D-OG-7.jpeg", 13 },
                    { "ultra-4d-5-0-carbon-1.jpeg", 14 },
                    { "ultra-4d-5-0-carbon-2.jpeg", 14 },
                    { "ultra-4d-5-0-carbon-3.jpeg", 14 },
                    { "ultra-4d-5-0-carbon-4.jpeg", 14 },
                    { "ultra-4d-5-0-carbon-5.jpeg", 14 },
                    { "ultra-4d-5-0-carbon-6.jpeg", 14 },
                    { "ultra-4d-5-0-carbon-7.jpeg", 14 },
                    { "ultra-4d-5-0-carbon-8.jpeg", 14 },
                    { "ultra-4d-grey-pink-gradient-1.jpeg", 15 },
                    { "ultra-4d-grey-pink-gradient-2.jpeg", 15 },
                    { "ultra-4d-grey-pink-gradient-3.jpeg", 15 },
                    { "ultra-4d-grey-pink-gradient-4.jpeg", 15 },
                    { "ultra-4d-grey-pink-gradient-5.jpeg", 15 },
                    { "ultra-4d-grey-pink-gradient-6.jpeg", 15 },
                    { "ultra-4d-grey-pink-gradient-7.jpeg", 15 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[,]
                {
                    { "ultra-4d-grey-pink-gradient-8.jpeg", 15 },
                    { "Ultra-4D-Chalk-White-1.jpeg", 16 },
                    { "Ultra-4D-Chalk-White-2.jpeg", 16 },
                    { "Ultra-4D-Chalk-White-3.jpeg", 16 },
                    { "Ultra-4D-Chalk-White-4.jpeg", 16 },
                    { "Ultra-4D-Chalk-White-5.jpeg", 16 },
                    { "Ultra-4D-Chalk-White-6.jpeg", 16 },
                    { "Ultra-4D-Chalk-White-7.jpeg", 16 },
                    { "Ultra-4D-Chalk-White-8.jpeg", 16 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg", 18 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-10.jpeg", 18 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-2.jpeg", 18 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-3.jpeg", 18 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-4.jpeg", 18 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-5.jpeg", 18 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-6.jpeg", 18 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-7.jpeg", 18 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-8.jpeg", 18 },
                    { "atmos-x-LeBron 18-Low-'Sakura'-9.jpeg", 18 },
                    { "Little-Posite-One-GS-Twilight-Pulse-1.png", 19 },
                    { "little-posite-one-xx-royal-1.png", 20 },
                    { "kyrie-5-ep-have-a-nike-day-1.png", 21 },
                    { "zoom-kd-12-wolf-grey-1.jpeg", 22 },
                    { "zoom-kd-12-wolf-grey-2.jpeg", 22 },
                    { "zoom-kd-12-wolf-grey-3.jpeg", 22 },
                    { "zoom-kd-12-wolf-grey-4.jpeg", 22 },
                    { "zoom-kd-12-wolf-grey-5.jpeg", 22 },
                    { "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-1.jpeg", 23 },
                    { "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-2.jpeg", 23 },
                    { "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-3.jpeg", 23 },
                    { "supreme-x-nike-half-zip-hooded-sweatshirt-white-1.jpeg", 24 },
                    { "supreme-x-nike-half-zip-hooded-sweatshirt-white-2.jpeg", 24 },
                    { "supreme-saint-michael-fleece-jacket-white-1.jpeg", 25 },
                    { "supreme-saint-michael-fleece-jacket-white-2.jpeg", 25 },
                    { "supreme-saint-michael-fleece-jacket-white-3.jpeg", 25 },
                    { "supreme-x-the-north-face-cargo-jacket-gold.jpeg", 26 },
                    { "supreme-x-the-north-face-s-logo-mountain-jacket-black-1.jpeg", 27 },
                    { "supreme-x-the-north-face-s-logo-mountain-jacket-black-2.jpeg", 27 },
                    { "supreme-x-the-north-face-s-logo-mountain-jacket-black-3.jpeg", 27 },
                    { "fear-of-god-essentials-kids-short-sleeve-polo-stretch-limo.jpeg", 28 },
                    { "fear-of-god-essentials-kids-pullover-hoodie-stretch-limo.jpeg", 29 },
                    { "fear-of-god-essentials-kids-sweatpant-stretch-limo.jpeg", 30 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[,]
                {
                    { "fear-of-god-essentials-rc-9fifty-cap-black-1.jpeg", 31 },
                    { "fear-of-god-essentials-rc-9fifty-cap-black-2.jpeg", 31 },
                    { "fear-of-god-essentials-x-mr-porter-exclusive-hoodie-vicunia.jpeg", 32 }
                });

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "CreatedAt", "ModifiledAt", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2633), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "8" },
                    { 2, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2634), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "8.5" },
                    { 3, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2635), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "9" },
                    { 4, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2640), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "8" },
                    { 5, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2640), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "8.5" },
                    { 6, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2641), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "9" },
                    { 7, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 100, "8" },
                    { 8, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 100, "8.5" },
                    { 9, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2643), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 100, "9" },
                    { 10, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 100, "8" },
                    { 11, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2645), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 100, "8.5" },
                    { 12, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2645), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 100, "9" },
                    { 13, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "8" },
                    { 14, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2647), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "8.5" },
                    { 15, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2647), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "9" },
                    { 16, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2648), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 100, "8" },
                    { 17, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2649), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 100, "8.5" },
                    { 18, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2649), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 100, "9" },
                    { 19, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2650), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 100, "8" },
                    { 20, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 100, "8.5" },
                    { 21, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 100, "9" },
                    { 22, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2653), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 100, "8" },
                    { 23, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2654), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 100, "8.5" },
                    { 24, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2654), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 100, "9" },
                    { 25, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2655), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 100, "8" },
                    { 26, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2656), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 100, "8.5" },
                    { 27, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2657), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 100, "9" },
                    { 28, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2658), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100, "10.5" },
                    { 29, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2658), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100, "11" },
                    { 30, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2659), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100, "11.5" },
                    { 31, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2660), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 100, "8" },
                    { 32, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2662), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 100, "8.5" },
                    { 33, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2663), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 100, "9" },
                    { 34, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2663), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100, "8" },
                    { 35, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2664), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100, "8.5" },
                    { 36, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2702), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100, "9" },
                    { 37, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2703), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 100, "8" },
                    { 38, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2704), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 100, "8.5" },
                    { 39, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2705), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 110, "9" }
                });

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "CreatedAt", "ModifiledAt", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { 40, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2706), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 100, "8" },
                    { 41, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2706), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 100, "8.5" },
                    { 42, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2707), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 110, "9" },
                    { 43, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2708), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 100, "8" },
                    { 44, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2710), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 100, "8.5" },
                    { 45, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2710), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 110, "9" },
                    { 46, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 100, "8" },
                    { 47, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2712), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 100, "8.5" },
                    { 48, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2712), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 110, "9" },
                    { 49, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2713), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 100, "8" },
                    { 50, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 100, "8.5" },
                    { 51, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 110, "9" },
                    { 52, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2715), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 100, "8" },
                    { 53, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2717), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 100, "8.5" },
                    { 54, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2718), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 110, "9" },
                    { 55, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2720), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 100, "3" },
                    { 56, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2721), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 100, "3.5" },
                    { 57, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2721), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 110, "4" },
                    { 58, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2723), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 100, "3" },
                    { 59, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2725), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 100, "3.5" },
                    { 60, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2726), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 110, "4" },
                    { 61, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2726), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 100, "8" },
                    { 62, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2727), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 100, "8.5" },
                    { 63, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2728), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 110, "9" },
                    { 64, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2728), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 100, "8" },
                    { 65, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2730), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 100, "8.5" },
                    { 66, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 155, "9" },
                    { 67, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 100, "M" },
                    { 68, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2732), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 100, "L" },
                    { 69, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2733), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 155, "XL" },
                    { 70, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2734), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 100, "M" },
                    { 71, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2735), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 100, "L" },
                    { 72, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2736), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 155, "XL" },
                    { 73, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2737), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 100, "M" },
                    { 74, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2737), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 100, "L" },
                    { 75, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2738), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 155, "XL" },
                    { 76, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2739), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 100, "M" },
                    { 77, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2739), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 100, "L" },
                    { 78, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2740), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 100, "M" },
                    { 79, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2742), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 100, "L" },
                    { 80, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2744), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 100, "XL" },
                    { 81, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2744), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 100, "8" }
                });

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "CreatedAt", "ModifiledAt", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { 82, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2746), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 100, "10" },
                    { 83, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2747), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, "2/3" },
                    { 84, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2748), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, "4" },
                    { 85, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2750), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, "4.5" },
                    { 86, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2751), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 100, "2/3" },
                    { 87, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2753), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 100, "4" },
                    { 88, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2754), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 100, "6" },
                    { 89, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2755), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 100, "One Size" },
                    { 90, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2756), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 100, "4" },
                    { 91, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2757), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 100, "6" },
                    { 92, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2758), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 100, "8" }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2790), 1, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2789), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2791), 2, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2791), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2793), 3, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2792), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 326.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2794), 4, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2793), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 540.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2796), 5, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2796), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 675.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2797), 6, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2797), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 568.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2798), 7, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2798), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 229.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2799), 8, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2799), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2800), 9, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2800), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 223.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2801), 10, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2801), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 342.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2802), 11, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2802), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 311.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2803), 12, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2803), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2804), 13, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2804), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 319.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2805), 14, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2805), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 318.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2806), 15, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2806), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 318.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2839), 16, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2838), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 325.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2840), 17, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2840), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 331.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2841), 18, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2841), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2842), 19, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2842), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 222.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2843), 20, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2843), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 236.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2844), 21, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2844), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 240.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2845), 22, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2845), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 145.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2846), 23, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2846), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2847), 24, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2847), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2848), 25, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2848), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2849), 26, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2849), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2850), 27, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2850), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2851), 28, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2851), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 189.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2852), 29, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2852), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2853), 30, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2853), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2854), 31, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2854), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 209.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2855), 32, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2855), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2856), 33, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2856), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2857), 34, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2857), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 390.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2858), 35, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2858), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 466.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2860), 36, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2860), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2861), 37, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2861), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 146.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2863), 38, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2862), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 140.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2864), 39, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2864), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2865), 40, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2865), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 209.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2866), 41, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2866), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 198.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2867), 42, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2867), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2868), 43, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2868), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2869), 44, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2869), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 140.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2870), 45, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2870), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2871), 46, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2870), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2872), 47, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2871), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 102.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2874), 48, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2874), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 229.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2875), 49, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2876), 50, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2876), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2877), 51, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2877), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2878), 52, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2878), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 237.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2879), 53, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2879), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 202.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2880), 54, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2880), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 185.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2881), 55, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2881), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2882), 56, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2882), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 75.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2883), 57, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2883), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2884), 58, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2884), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 259.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2885), 59, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2885), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 244.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2886), 60, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2886), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2888), 61, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2887), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 483.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2889), 62, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2888), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2890), 63, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2889), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 564.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2891), 64, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2890), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2892), 65, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2891), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2893), 66, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2892), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 155.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2894), 67, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2893), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 745.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2895), 68, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2894), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 740.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2896), 69, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2895), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1718.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2897), 70, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2896), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2898), 71, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2897), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2899), 72, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2898), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 360.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2900), 73, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2899), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 235.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2901), 74, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2900), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2902), 75, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2901), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2903), 76, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2902), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 775.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2904), 77, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2903), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2905), 78, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2904), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 780.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2906), 79, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2905), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 729.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2907), 80, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2906), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 895.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2908), 81, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2907), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2909), 82, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2908), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2910), 83, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2909), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2911), 84, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2911), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 159.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2912), 85, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2912), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 137.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2914), 86, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2915), 87, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2914), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 124.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2916), 88, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2915), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2917), 89, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2916), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2918), 90, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2917), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 203.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2919), 91, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2918), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 201.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2920), 92, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2919), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 194.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CartSessionId",
                table: "AspNetUsers",
                column: "CartSessionId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartSessionId",
                table: "CartItems",
                column: "CartSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_CartSessions_UserId",
                table: "CartSessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountProduct_ProductsId",
                table: "DiscountProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentDetailId",
                table: "Orders",
                column: "PaymentDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInventory_ProductId_Size",
                table: "ProductInventory",
                columns: new[] { "ProductId", "Size" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandSilhouetteID",
                table: "Products",
                column: "BrandSilhouetteID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPayments_UserId",
                table: "UserPayments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserShippingAddress_UserId_Address",
                table: "UserShippingAddress",
                columns: new[] { "UserId", "Address" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WantedProducts_ProductId",
                table: "WantedProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CartSessions_CartSessionId",
                table: "AspNetUsers",
                column: "CartSessionId",
                principalTable: "CartSessions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartSessions_AspNetUsers_UserId",
                table: "CartSessions");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "DiscountProduct");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductPrices");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserPayments");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserShippingAddress");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "WantedProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductInventory");

            migrationBuilder.DropTable(
                name: "paymentDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "BrandSilhouttes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CartSessions");
        }
    }
}
