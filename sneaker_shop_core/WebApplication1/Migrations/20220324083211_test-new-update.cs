using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class testnewupdate : Migration
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
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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
                name: "BrandSilhouetteProduct",
                columns: table => new
                {
                    BrandSilhouetteNameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandSilhouetteProduct", x => new { x.BrandSilhouetteNameId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_BrandSilhouetteProduct_BrandSilhouttes_BrandSilhouetteNameId",
                        column: x => x.BrandSilhouetteNameId,
                        principalTable: "BrandSilhouttes",
                        principalColumn: "NameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandSilhouetteProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
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
                    { new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"), "b2d48680-a7c3-4ac4-8e3c-34aa9e258ade", "admin", "admin" },
                    { new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"), "7c58db01-cca3-4c73-82b7-faee6c68c195", "SuperAdmin", "superadmin" },
                    { new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"), "5e2ed465-f628-4453-859d-e01d67f50758", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CartSessionId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"), 0, null, "d0bb455d-da12-4724-9076-e4e6ae4a9e50", "superadmin@superadmin.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEGH2xeIszbvbtgIavr2B/C2SbMeHKAUgR935BGpIZfRJOkkd/5Dvno2n5fl0e5kfZw==", null, false, "2586945e-f3e1-4bf4-b662-63fd05a78a94", false, "superAdmin" },
                    { new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"), 0, null, "c0fb2d20-6344-4b7f-b6b8-8476ff3fadf8", "admin@admin.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEP10bDYrJ3Eu+OeXLeIaTfV5JW/hTH75dBOLjhubhrVzrm2Pg8Pyt7D7e99AT1yEFQ==", null, false, "9e1cd35b-e2be-4ec6-b683-f2aabf8b13c4", false, "admin" },
                    { new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"), 0, null, "98f4ba13-f020-429e-9d92-26300194c3d7", "customer1@customer1.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEIn70DEOkwLLn/T6S2NwS0jo3oZgo+UIR1NPxCe/dj9Z+JcPLCUcdHU3asgW/enPA==", null, false, "0d9e2070-60fa-48d6-a8eb-77d82f9d497c", false, "customer1" },
                    { new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"), 0, null, "651eb5e1-f6a1-407b-8cf3-a3b2d541a2aa", "user@user.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEVQawNyWhr+aUVtAz+tIhc9dk3Lk877m1ov6t+/5MGCksEkk+ZCy9em2SRin/99RQ==", null, false, "a5215d40-8721-40ba-ad89-3d6f65069da3", false, "defaultuser" },
                    { new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"), 0, null, "4f70daa6-e8cf-4ba9-bfc3-7b6d25d1668d", "customer3@customer3.com", false, false, null, null, null, "AQAAAAEAACcQAAAAED3KifVa0XZKmWJRTFc+64n9rJe/nhYuuInc/TqJiNWb/2xQK3Z7/omdsDoYkFgPZA==", null, false, "65bc81ce-45b1-45b4-84c8-1a46e920d613", false, "customer3" },
                    { new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"), 0, null, "fb594e2f-62d9-4feb-84d6-94580e4868c8", "customer2@customer2.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEBcdE7Dd1q+CIpeIgJ93rkAl9sXSIWYFhzt+DA89NcOWGhB1qQILrRHZLtTXFys83Q==", null, false, "b1155695-4dbf-4d7f-85ce-0b69e13e4ab7", false, "customer2" }
                });

            migrationBuilder.InsertData(
                table: "BrandSilhouttes",
                columns: new[] { "NameId", "CreatedAt", "Icon", "ModifiedAt", "Story", "Type" },
                values: new object[,]
                {
                    { "Adidas", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6579), "adidas.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adi Dassler founded adidas in 1949 in Herzogenaurach, Germany. Building on the reputation of the brand’s spiked running shoes and football cleats, Dassler turned adidas into a global icon, redefining sneakers and apparel in the process. Today, adidas is considered one of the world’s most influential brands, responsible for the Stan Smith, Yeezy sneakers and more.", "Brand" },
                    { "Air Jordan", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6852), "jordan.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In 1984, Nike unveiled the Air Jordan 1, a basketball sneaker designed by Peter Moore for a young Michael Jordan. The iconic silhouette transcended sneakers and sports, altering the trajectory of style forever. Today, Michael Jordan’s namesake brand continues to inspire sportswear and style movements around the world through new releases, retro drops and unexpected collaborations.", "Brand" },
                    { "Air Jordan 1", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7009), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Air Jordan 11", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7064), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Air Jordan 4", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7022), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Air Jordan 5", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7037), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Air Jordan 6", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7050), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Fear of God Essentials", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6895), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In 2018, Jerry Lorenzo launched Fear of God Essentials, a pared-back version of Fear of God. Each seasonal collection brings the line’s concept into sharper focus, uniting elevated sportswear basics with subdued shades and minimal branding.", "Brand" },
                    { "Kyrie 5", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7119), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "LeBron 18", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7092), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Little Posite One", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7106), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Nike", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6828), "nike.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Founded by Bill Bowerman and Phil Knight in 1964, Nike is synonymous with performance and innovation. Alongside its apparel offerings, the sportswear giant is responsible for a number of iconic sneakers, including the Air Force 1, the Air Max franchise and more. Today, Nike is among the world’s most recognized brands, identified by its wordmark and Swoosh logo.", "Brand" },
                    { "Supreme", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6867), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Founded by James Jebbia in 1994, Supreme is a New York-based skate brand known for its subcultural references and controversial graphics. Today, Supreme is considered one of style’s most influential voices, blurring the lines between streetwear and luxury through collaborations with artists, fashion houses and sneaker brands.", "Brand" },
                    { "Ultra 4D", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7078), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Yeezy", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6881), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In late 2013, Kanye West and adidas announced their forthcoming partnership. In 2015, the two delivered on this news, arriving in the form of Yeezy Season 1, a collection of sneakers and apparel debuted at New York Fashion Week. Since the first collection, Yeezy has influenced style movements worldwide.", "Brand" },
                    { "Yeezy 350", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6995), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Yeezy 450", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6981), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Yeezy 700", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6909), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Yeezy Foam Runner", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6967), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Yeezy Knit Runner", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6953), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" },
                    { "Zoom KD 12", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7133), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Silhouette" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Color", "CoverImage", "CreatedAt", "Description", "ModifiedAt", "Name", "Releasedate", "Type", "UserType", "Wallpaper" },
                values: new object[,]
                {
                    { 1, "Boots", "Tan", "yeezy-boost-700-mauve-1.jpeg", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7331), "The adidas Yeezy Boost 700 V2 ‘Mauve’ brings back a popular colorway first seen on a Yeezy Boost 700 release from 2018. The sneaker’s titular hue is executed on a textured mesh upper with arcing no-sew skins along the quarter panel and greenish-grey suede overlays throughout. Responsive cushioning comes courtesy of a full-length drop-in Boost midsole, housed within a sculpted polyurethane carrier. Underfoot, a herringbone-traction rubber outsole provides optimal grip.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Boost 700 V2 'Mauve'", new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 2, "LifeStyle", "Sulfur", "yeezy-knit-runner-sulfur-1.jpeg", new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7575), "The adidas Yeezy Knit Runner ‘Sulfur’ delivers the debut colorway of Kanye West’s sock-like silhouette, which launched exclusively through the artist’s Yeezy Supply site. The fully knit build, rendered in a neutral tan shade with a contrasting mustard yellow finish throughout the majority of the upper, utilizes slip-on construction devoid of exterior branding. Embellishments are limited to sizing information stamped on the lateral collar. The sneaker rides on a durable rubber outsole in a matching yellow finish, featuring a modified herringbone tread and adidas branding under the heel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Knit Runner 'Sulfur'", new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null }
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
                    { "yeezy-knit-runner-sulfur-9.jpeg", 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "CreatedAt", "ModifiledAt", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7786), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "8" },
                    { 2, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7788), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "8.5" },
                    { 3, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7789), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "9" },
                    { 4, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7790), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "8" },
                    { 5, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7790), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "8.5" },
                    { 6, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7791), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "9" }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7807), 1, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7806), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350.0 },
                    { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7808), 2, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7807), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385.0 },
                    { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7809), 3, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7809), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 326.0 },
                    { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7810), 4, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7810), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 540.0 },
                    { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7811), 5, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 675.0 },
                    { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7812), 6, new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7812), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 568.0 }
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
                name: "IX_BrandSilhouetteProduct_ProductsId",
                table: "BrandSilhouetteProduct",
                column: "ProductsId");

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
                name: "BrandSilhouetteProduct");

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
                name: "UserPayments");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserShippingAddress");

            migrationBuilder.DropTable(
                name: "WantedProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BrandSilhouttes");

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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CartSessions");
        }
    }
}
