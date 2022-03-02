using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Data.Migrations
{
    public partial class seeddata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Adidas",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 418, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 418, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Fear of God Essentials",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 418, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Nike",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 418, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Supreme",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 418, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 418, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "IdentityRole<Guid>",
                keyColumn: "Id",
                keyValue: new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"),
                column: "ConcurrencyStamp",
                value: "f92fe452-cf35-4ca0-b6cf-e3f11aea099d");

            migrationBuilder.UpdateData(
                table: "IdentityRole<Guid>",
                keyColumn: "Id",
                keyValue: new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"),
                column: "ConcurrencyStamp",
                value: "fcb72d10-4339-4170-a89c-3fcbd4cbf6e1");

            migrationBuilder.UpdateData(
                table: "IdentityRole<Guid>",
                keyColumn: "Id",
                keyValue: new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"),
                column: "ConcurrencyStamp",
                value: "032de5a7-5356-44d0-b1ce-9c7503f550dc");

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "CreatedAt", "ModifiledAt", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2622), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "8" },
                    { 2, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2625), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "8.5" },
                    { 3, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2626), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "9" },
                    { 4, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2627), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "8" },
                    { 5, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "8.5" },
                    { 6, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2693), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 100, "9" },
                    { 7, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2694), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 100, "8" },
                    { 8, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2695), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 100, "8.5" },
                    { 9, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2696), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 100, "9" },
                    { 10, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2697), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 100, "8" },
                    { 11, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2697), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 100, "8.5" },
                    { 12, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2698), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 100, "9" },
                    { 13, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2699), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "8" },
                    { 14, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2700), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "8.5" },
                    { 15, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "9" },
                    { 16, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 100, "8" },
                    { 17, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2702), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 100, "8.5" },
                    { 18, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2703), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 100, "9" },
                    { 19, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2704), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 100, "8" },
                    { 20, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2705), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 100, "8.5" },
                    { 21, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2705), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 100, "9" },
                    { 22, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2706), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 100, "8" },
                    { 23, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2707), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 100, "8.5" },
                    { 24, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2707), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 100, "9" },
                    { 25, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2709), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 100, "8" },
                    { 26, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2710), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 100, "8.5" },
                    { 27, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 100, "9" },
                    { 28, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100, "10.5" },
                    { 29, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2712), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100, "11" },
                    { 30, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2713), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100, "11.5" },
                    { 31, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2713), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 100, "8" },
                    { 32, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 100, "8.5" },
                    { 33, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2715), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 100, "9" }
                });

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "CreatedAt", "ModifiledAt", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { 34, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2715), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100, "8" },
                    { 35, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2716), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100, "8.5" },
                    { 36, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2717), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100, "9" },
                    { 37, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2718), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 100, "8" },
                    { 38, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2721), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 100, "8.5" },
                    { 39, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2722), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 110, "9" },
                    { 40, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2722), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 100, "8" },
                    { 41, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2724), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 100, "8.5" },
                    { 42, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2724), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 110, "9" },
                    { 43, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2725), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 100, "8" },
                    { 44, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2726), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 100, "8.5" },
                    { 45, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2726), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 110, "9" },
                    { 46, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2727), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 100, "8" },
                    { 47, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2728), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 100, "8.5" },
                    { 48, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2728), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 110, "9" },
                    { 49, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2729), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 100, "8" },
                    { 50, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2730), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 100, "8.5" },
                    { 51, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 110, "9" },
                    { 52, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 100, "8" },
                    { 53, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2732), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 100, "8.5" },
                    { 54, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2733), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 110, "9" },
                    { 55, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2734), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 100, "3" },
                    { 56, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2734), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 100, "3.5" },
                    { 57, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2735), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 110, "4" },
                    { 58, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2736), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 100, "3" },
                    { 59, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2736), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 100, "3.5" },
                    { 60, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2737), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 110, "4" },
                    { 61, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2738), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 100, "8" },
                    { 62, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2738), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 100, "8.5" },
                    { 63, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2739), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 110, "9" },
                    { 64, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2740), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 100, "8" },
                    { 65, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2741), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 100, "8.5" },
                    { 66, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2741), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 155, "9" },
                    { 67, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2742), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 100, "M" },
                    { 68, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2743), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 100, "L" },
                    { 69, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2744), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 155, "XL" },
                    { 70, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2746), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 100, "M" },
                    { 71, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2746), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 100, "L" },
                    { 72, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2747), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 155, "XL" },
                    { 73, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2748), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 100, "M" },
                    { 74, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2749), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 100, "L" },
                    { 75, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2749), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 155, "XL" }
                });

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "CreatedAt", "ModifiledAt", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { 76, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2750), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 100, "M" },
                    { 77, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2752), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 100, "L" },
                    { 78, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2753), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 100, "M" },
                    { 79, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2754), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 100, "L" },
                    { 80, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2755), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 100, "XL" },
                    { 81, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2755), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 100, "8" },
                    { 82, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2756), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 100, "10" },
                    { 83, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2757), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, "2/3" },
                    { 84, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2757), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, "4" },
                    { 85, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2758), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, "4.5" },
                    { 86, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2759), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 100, "2/3" },
                    { 87, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2760), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 100, "4" },
                    { 88, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2761), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 100, "6" },
                    { 89, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2762), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 100, "One Size" },
                    { 90, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2763), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 100, "4" },
                    { 91, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2763), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 100, "6" },
                    { 92, new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2764), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 100, "8" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09854b86-71c3-4da9-9b7d-8c63e50cb5c4", "AQAAAAEAACcQAAAAEAXe5PIFZyGavmzLFdqMQysTj5bTjdXc3FFSxVi2uGso2l+mpxx5a+Xi0WBmlXq7TA==", "5a5605c8-f7e3-49f7-b93f-144f0325f2d3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "345c7829-3da1-48f3-ac38-21672b723cd0", "AQAAAAEAACcQAAAAEJzpRlT5HwLlkGxhD20EF5kQQHK7L6yi5qTU/BoeZSzeu9SYZwjzD6oaRfEi6o5Y7A==", "d72914a3-6216-4fd2-baa2-52418338ed4c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ae2f0b6-6f2f-49c3-9381-ed2847f1b560", "AQAAAAEAACcQAAAAECI8RhRNwC8e0Y+de8R9WOjBr2pPW6mKKXPtstQiXWB30G3XkOJeJmMEzxhILKfwtg==", "df6b42b4-c0d6-4e88-a29d-acf47db5d19e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a461b262-e751-4c15-ac8e-6c1ade09ca7e", "AQAAAAEAACcQAAAAEIJX2TDJPKMb2H0HIb1uLjTapk7QvMOX6JX493hvv1Ktay4Y/1RwjGBTm8m7skNVOA==", "021b5d92-32a9-4d0c-b5df-848d64632129" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a0ce531-5ff3-42fe-9ad5-afafce0b3d2d", "AQAAAAEAACcQAAAAEIXjG4jpB5DNnJna+UkKYpR1VYvHBjkiRXWR4JZRfXhZZe6HK5QpRaYLHHNYeaNZ5Q==", "389ec77a-70d7-4d20-8e79-025e6b8fb675" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfc34a68-8b6d-4d20-ae3f-d9f18c767faa", "AQAAAAEAACcQAAAAEC7+xGwfvTE9v/1tON1mTFJJJCpVecxm0CebmZ+IXNOaWmhHYoRdp4ZPmkiyvMxZvQ==", "b79eaaaa-9e0f-47ee-9d5d-215a8e5c6e20" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Adidas",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Fear of God Essentials",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Nike",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Supreme",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "IdentityRole<Guid>",
                keyColumn: "Id",
                keyValue: new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"),
                column: "ConcurrencyStamp",
                value: "857f5778-6ecd-4c05-a647-a6b321522977");

            migrationBuilder.UpdateData(
                table: "IdentityRole<Guid>",
                keyColumn: "Id",
                keyValue: new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"),
                column: "ConcurrencyStamp",
                value: "a8859393-1942-45a2-b1fc-39f561af2d0b");

            migrationBuilder.UpdateData(
                table: "IdentityRole<Guid>",
                keyColumn: "Id",
                keyValue: new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"),
                column: "ConcurrencyStamp",
                value: "22002a93-55a3-4ac0-a3db-f1ab09836a3d");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5d9a2b9-c09d-4a58-869f-9090f675fdfc", "AQAAAAEAACcQAAAAENVvoZ6nbwGZ9D5/VZSTpHBwRz1kZVcEiiW6YA5Znb5TUCuUuxIdMeQRf7k2IrP2gg==", "edbe5209-38e3-42fd-8a16-6a5a45d737f5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de9ab822-cf4e-4bc5-893a-a22c4a372429", "AQAAAAEAACcQAAAAEK21jruPuxwHC/YEJVT7FEs+UKVIQCMP6Y6Bo3IfcM2fYsJFpI8tfjKhvUkGJQtRwQ==", "2465a7b7-6aa4-447d-9c39-5e2a3a067a6c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f551e29-6a22-4b18-891d-90a223f25290", "AQAAAAEAACcQAAAAED880rmUyKcpMBZSPd6676gtMfClZgMXFpVVvv7zX7QFCycDLO7ZyWLg9zxR+oMMhw==", "4aab91f0-efd9-4f9b-af13-ce80ce8ac7dc" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "923a4eec-26a2-4bb2-9aa5-20ee0a6c7eca", "AQAAAAEAACcQAAAAECohSneJ5eMW3GYXlQKyGg4KCGHgkwoqV7Tz/YmtuBYBSLOkuk+D6ASr9LFNr9J7YQ==", "275f2bca-efda-4c10-a24a-b9d1d74abdb5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a2088e2-9c4d-4abf-bfab-27894d999086", "AQAAAAEAACcQAAAAEDMutAk1/QuMThXMBhCgf3HIVtUoF41rfQEyOR/liEG3SotMqF0eOzJ2S1VVogdsZQ==", "76ba6b9b-de42-41ce-b783-b1783a52588c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94bc7c9f-5fa6-4d90-be14-d7b411761364", "AQAAAAEAACcQAAAAEJizwbd1A2M907TlWBONyoDCr30hj9rGjgWU1Qcyno2z7rLsLY8Q9gh/tP0YFdesHw==", "1a60c393-7a9a-4c85-abdb-21410cba4d17" });
        }
    }
}
