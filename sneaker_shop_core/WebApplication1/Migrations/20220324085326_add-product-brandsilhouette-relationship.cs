using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class addproductbrandsilhouetterelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7807), 1 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7808), 2 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7809), 3 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7810), 4 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7811), 5 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7812), 6 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"),
                column: "ConcurrencyStamp",
                value: "6ee12b66-8a42-439e-b93f-342b3130ca0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"),
                column: "ConcurrencyStamp",
                value: "922c6ea6-8a80-4536-8ad7-78ee321ab5d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"),
                column: "ConcurrencyStamp",
                value: "d65dc015-cf89-468a-bbb1-b03dd3525c2e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eed9308f-4b06-4b70-b035-4f75d5db2b04", "AQAAAAEAACcQAAAAEANkqix16RVsDqIUFpNzVpE9k33eKhkKKHd+3RULNd2+rS3n4e68tojOxdzAnxmJsw==", "7873bad0-8e6a-4597-9249-892e246fce0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d486343d-eeab-4903-8c8e-a7a8abb5c790", "AQAAAAEAACcQAAAAEIf7yL1L+2kSpnvr+9+cPUp2nnJxS9Y5fzp+iqSMMen+xzwOYHiQLMScCsYpr/1YCA==", "656bad44-c1a4-40c5-825a-404c8bb205c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c163be85-6502-4e4f-bb68-0679f4b896b6", "AQAAAAEAACcQAAAAEJAndRP03PfV3t6FgqcvD7Aardo6oStj/n6XHrlViR9i7tPylHlmI/fqLxMeZyQe7g==", "05904173-dd4d-4db2-bebb-9cc6b34ee521" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c268ca20-07b9-497e-a185-b81e339ed035", "AQAAAAEAACcQAAAAEN7DBfCZVxsyIztg+bH+574U0zk2ngza478LWYfeo3urFM2jhAgtkb38pJCxq0DyJw==", "18e0c6e0-de81-4c8e-b853-b322ce8b3ad5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d73a39c-b935-40bb-a3ed-e7f5853aa385", "AQAAAAEAACcQAAAAEDk/T3h+UjHOuvfF+cONLP3CFVngbxk+T0M1mnQLslLXBZ/7RI2Eej04l2Sa8SJ7+w==", "0d2d1951-5e13-4ab4-88da-06b8ac8552f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12867106-b437-4eea-8ddc-004dc3bd57ce", "AQAAAAEAACcQAAAAEGHxmitiahfyrExXy61ZOZZR8GrqYPbv6a8Qsq2y6IfucTFkPMuHAIxK6nPkBlSm5Q==", "91e3239b-a881-453f-a167-2311d3237e23" });

            migrationBuilder.InsertData(
                table: "BrandSilhouetteProduct",
                columns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                values: new object[,]
                {
                    { "Adidas", 1 },
                    { "Adidas", 2 },
                    { "Yeezy", 1 },
                    { "Yeezy", 2 },
                    { "Yeezy 700", 1 },
                    { "Yeezy Knit Runner", 2 }
                });

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Adidas",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 1",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 11",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 4",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 5",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 6",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Fear of God Essentials",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Kyrie 5",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "LeBron 18",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Little Posite One",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Nike",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Supreme",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Ultra 4D",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy 350",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy 450",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy 700",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy Foam Runner",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy Knit Runner",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Zoom KD 12",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8194), 1, new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8194), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350.0 },
                    { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8196), 2, new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8195), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385.0 },
                    { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8197), 3, new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8197), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 326.0 },
                    { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8198), 4, new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8198), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 540.0 },
                    { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8199), 5, new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8199), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 675.0 },
                    { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8200), 6, new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8200), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 568.0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(7383));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 1 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 2 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy", 1 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy", 2 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy 700", 1 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy Knit Runner", 2 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8194), 1 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8196), 2 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8197), 3 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8198), 4 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8199), 5 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 15, 53, 25, 396, DateTimeKind.Local).AddTicks(8200), 6 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"),
                column: "ConcurrencyStamp",
                value: "b2d48680-a7c3-4ac4-8e3c-34aa9e258ade");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"),
                column: "ConcurrencyStamp",
                value: "7c58db01-cca3-4c73-82b7-faee6c68c195");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"),
                column: "ConcurrencyStamp",
                value: "5e2ed465-f628-4453-859d-e01d67f50758");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0bb455d-da12-4724-9076-e4e6ae4a9e50", "AQAAAAEAACcQAAAAEGH2xeIszbvbtgIavr2B/C2SbMeHKAUgR935BGpIZfRJOkkd/5Dvno2n5fl0e5kfZw==", "2586945e-f3e1-4bf4-b662-63fd05a78a94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0fb2d20-6344-4b7f-b6b8-8476ff3fadf8", "AQAAAAEAACcQAAAAEP10bDYrJ3Eu+OeXLeIaTfV5JW/hTH75dBOLjhubhrVzrm2Pg8Pyt7D7e99AT1yEFQ==", "9e1cd35b-e2be-4ec6-b683-f2aabf8b13c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98f4ba13-f020-429e-9d92-26300194c3d7", "AQAAAAEAACcQAAAAEEIn70DEOkwLLn/T6S2NwS0jo3oZgo+UIR1NPxCe/dj9Z+JcPLCUcdHU3asgW/enPA==", "0d9e2070-60fa-48d6-a8eb-77d82f9d497c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "651eb5e1-f6a1-407b-8cf3-a3b2d541a2aa", "AQAAAAEAACcQAAAAEEVQawNyWhr+aUVtAz+tIhc9dk3Lk877m1ov6t+/5MGCksEkk+ZCy9em2SRin/99RQ==", "a5215d40-8721-40ba-ad89-3d6f65069da3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f70daa6-e8cf-4ba9-bfc3-7b6d25d1668d", "AQAAAAEAACcQAAAAED3KifVa0XZKmWJRTFc+64n9rJe/nhYuuInc/TqJiNWb/2xQK3Z7/omdsDoYkFgPZA==", "65bc81ce-45b1-45b4-84c8-1a46e920d613" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb594e2f-62d9-4feb-84d6-94580e4868c8", "AQAAAAEAACcQAAAAEBcdE7Dd1q+CIpeIgJ93rkAl9sXSIWYFhzt+DA89NcOWGhB1qQILrRHZLtTXFys83Q==", "b1155695-4dbf-4d7f-85ce-0b69e13e4ab7" });

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Adidas",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 1",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 11",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 4",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 5",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 6",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Fear of God Essentials",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Kyrie 5",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "LeBron 18",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Little Posite One",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Nike",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Supreme",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Ultra 4D",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy 350",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy 450",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy 700",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy Foam Runner",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy Knit Runner",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Zoom KD 12",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7791));

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 15, 32, 11, 32, DateTimeKind.Local).AddTicks(7575));
        }
    }
}
