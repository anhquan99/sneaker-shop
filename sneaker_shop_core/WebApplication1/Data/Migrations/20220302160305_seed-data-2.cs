using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Data.Migrations
{
    public partial class seeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Adidas",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 963, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 963, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Fear of God Essentials",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 963, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Nike",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 963, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Supreme",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 963, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 963, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "IdentityRole<Guid>",
                keyColumn: "Id",
                keyValue: new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"),
                column: "ConcurrencyStamp",
                value: "cb295c29-3bc4-4e99-8cd6-dd71057fce86");

            migrationBuilder.UpdateData(
                table: "IdentityRole<Guid>",
                keyColumn: "Id",
                keyValue: new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"),
                column: "ConcurrencyStamp",
                value: "8a1a8011-cd51-44ee-9d5d-9e7071daab99");

            migrationBuilder.UpdateData(
                table: "IdentityRole<Guid>",
                keyColumn: "Id",
                keyValue: new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"),
                column: "ConcurrencyStamp",
                value: "ebb9b88a-29d1-436b-a48f-4dcb53d8e559");

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2483), 1, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2482), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2484), 2, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2484), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2486), 3, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2485), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 326.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2487), 4, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2486), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 540.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2488), 5, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2487), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 675.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2489), 6, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2488), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 568.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2490), 7, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2489), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 229.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2491), 8, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2490), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2492), 9, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2492), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 223.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2493), 10, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2493), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 342.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2494), 11, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2494), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 311.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2495), 12, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2495), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2496), 13, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2496), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 319.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2497), 14, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2497), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 318.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2498), 15, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2498), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 318.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2499), 16, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2499), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 325.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2500), 17, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2500), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 331.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2501), 18, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2501), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2503), 19, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2502), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 222.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2504), 20, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2503), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 236.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2508), 21, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2508), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 240.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2510), 22, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2509), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 145.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2511), 23, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2510), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2512), 24, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2511), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2513), 25, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2512), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2513), 26, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2513), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2514), 27, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2514), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2515), 28, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2515), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 189.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2516), 29, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2516), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2517), 30, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2517), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2518), 31, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2518), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 209.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2520), 32, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2519), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2521), 33, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2520), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2522), 34, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2521), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 390.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2523), 35, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2522), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 466.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2524), 36, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2523), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2525), 37, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2524), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 146.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2526), 38, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2525), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 140.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2527), 39, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2526), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2528), 40, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2527), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 209.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2529), 41, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2529), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 198.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2530), 42, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2531), 43, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2531), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2532), 44, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2532), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 140.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2533), 45, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2533), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2535), 46, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2534), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2536), 47, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2535), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 102.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2537), 48, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 229.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2538), 49, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2538), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2539), 50, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2539), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2540), 51, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2540), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2541), 52, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2541), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 237.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2542), 53, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2542), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 202.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2543), 54, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2543), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 185.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2544), 55, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2544), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2546), 56, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2545), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 75.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2546), 57, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2546), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2547), 58, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2547), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 259.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2548), 59, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2548), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 244.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2550), 60, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2550), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2552), 61, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2551), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 483.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2553), 62, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2552), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2554), 63, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2554), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 564.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2556), 64, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2555), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2557), 65, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2557), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2558), 66, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2558), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 155.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2560), 67, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2559), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 745.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2561), 68, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2560), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 740.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2562), 69, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2561), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1718.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2563), 70, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2562), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2564), 71, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2564), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2565), 72, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2565), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 360.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2566), 73, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2566), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 235.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2567), 74, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2567), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2568), 75, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2568), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2569), 76, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2569), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 775.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2570), 77, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2570), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2571), 78, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2571), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 780.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2572), 79, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 729.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2573), 80, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2573), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 895.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2574), 81, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2574), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2576), 82, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2575), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2577), 83, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2576), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2578), 84, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2578), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 159.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2579), 85, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2579), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 137.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2580), 86, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2580), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2581), 87, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2581), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 124.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2643), 88, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2644), 89, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2643), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2645), 90, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2645), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 203.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2646), 91, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 201.0 },
                    { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2647), 92, new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2647), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 194.0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 963, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee398283-e916-4c19-b051-72e40fa6d5bc", "AQAAAAEAACcQAAAAEJ1gUZ7NAveIZWBehYUC9JNLwICx14X9R+EDgBG0+JI2MOEmdRfK7MAoqGr3lDiegQ==", "f3cdc073-6562-4063-b568-59f8697aa51d" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57b4bd1a-71c6-4bda-97e4-59749aa097e2", "AQAAAAEAACcQAAAAEBgaks9PhQTXrqmCjcUWxXXGiCE42kIZAt/rbF9WCunZh15nQ4uvOP4siuGh8ZoJoA==", "a5c60ea4-6e08-4b53-8861-fdaa68228c84" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35c3cd03-6c53-490a-bfb4-d409d3d6b22c", "AQAAAAEAACcQAAAAEH+j8kBbCYgXFoR6DNzJ7xUdTZvGqxFgz+s+tNzm2Z9MjZ3vuqhAjoTVLHkI/Q7ElA==", "f6d44ca4-e2f1-4898-9059-8990c701c2d0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a08b7a84-b6c9-4587-8cf2-3ca29d42d5dd", "AQAAAAEAACcQAAAAEJInFuSJTDA9EB+ttUVFhGyC5XlPGPqdy36gp4rzVwQm6WKBRv5mVG3hHJaSm6Oeqw==", "2009ceb7-f596-41e1-8094-336a21e24f99" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1df52eb-97da-4d73-bfbb-b3be2107742d", "AQAAAAEAACcQAAAAEMAGWCXOsK6dZPdIIZVcNtc4F8F+CJb6vlqkt/ovAcBmQVyqjvx70Sda45LLlzNPKw==", "58649110-cafe-4c7a-b9a9-48013116ed62" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ebe119f-c05a-4428-af65-c696fea3b29f", "AQAAAAEAACcQAAAAECZRfWSOgMOqVm53rPgCp0r5HmiW1VRmMqiqP/CNJufXhkb1BcTru+D7BS/STsjR1Q==", "0d9950f5-6493-4a7f-9fc5-c7dcf647d838" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2483), 1 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2484), 2 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2486), 3 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2487), 4 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2488), 5 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2489), 6 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2490), 7 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2491), 8 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2492), 9 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2493), 10 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2494), 11 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2495), 12 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2496), 13 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2497), 14 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2498), 15 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2499), 16 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2500), 17 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2501), 18 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2503), 19 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2504), 20 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2508), 21 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2510), 22 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2511), 23 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2512), 24 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2513), 25 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2513), 26 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2514), 27 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2515), 28 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2516), 29 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2517), 30 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2518), 31 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2520), 32 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2521), 33 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2522), 34 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2523), 35 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2524), 36 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2525), 37 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2526), 38 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2527), 39 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2528), 40 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2529), 41 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2530), 42 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2531), 43 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2532), 44 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2533), 45 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2535), 46 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2536), 47 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2537), 48 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2538), 49 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2539), 50 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2540), 51 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2541), 52 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2542), 53 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2543), 54 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2544), 55 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2546), 56 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2546), 57 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2547), 58 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2548), 59 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2550), 60 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2552), 61 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2553), 62 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2554), 63 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2556), 64 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2557), 65 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2558), 66 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2560), 67 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2561), 68 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2562), 69 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2563), 70 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2564), 71 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2565), 72 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2566), 73 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2567), 74 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2568), 75 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2569), 76 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2570), 77 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2571), 78 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2572), 79 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2573), 80 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2574), 81 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2576), 82 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2577), 83 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2578), 84 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2579), 85 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2580), 86 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2581), 87 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2643), 88 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2644), 89 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2645), 90 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2646), 91 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 3, 4, 964, DateTimeKind.Local).AddTicks(2647), 92 });

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

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 22, 56, 0, 419, DateTimeKind.Local).AddTicks(2764));

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
    }
}
