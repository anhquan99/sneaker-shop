using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class add_type_to_brandSilhouette : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-1", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-2", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-3", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-4", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-5", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-6", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-7", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-8", 10 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2790), 1 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2791), 2 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2793), 3 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2794), 4 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2796), 5 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2797), 6 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2798), 7 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2799), 8 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2800), 9 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2801), 10 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2802), 11 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2803), 12 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2804), 13 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2805), 14 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2806), 15 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2839), 16 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2840), 17 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2841), 18 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2842), 19 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2843), 20 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2844), 21 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2845), 22 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2846), 23 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2847), 24 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2848), 25 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2849), 26 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2850), 27 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2851), 28 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2852), 29 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2853), 30 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2854), 31 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2855), 32 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2856), 33 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2857), 34 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2858), 35 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2860), 36 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2861), 37 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2863), 38 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2864), 39 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2865), 40 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2866), 41 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2867), 42 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2868), 43 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2869), 44 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2870), 45 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2871), 46 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2872), 47 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2874), 48 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2875), 49 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2876), 50 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2877), 51 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2878), 52 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2879), 53 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2880), 54 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2881), 55 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2882), 56 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2883), 57 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2884), 58 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2885), 59 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2886), 60 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2888), 61 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2889), 62 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2890), 63 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2891), 64 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2892), 65 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2893), 66 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2894), 67 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2895), 68 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2896), 69 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2897), 70 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2898), 71 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2899), 72 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2900), 73 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2901), 74 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2902), 75 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2903), 76 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2904), 77 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2905), 78 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2906), 79 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2907), 80 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2908), 81 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2909), 82 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2910), 83 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2911), 84 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2912), 85 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2914), 86 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2915), 87 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2916), 88 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2917), 89 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2918), 90 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2919), 91 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2920), 92 });

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "BrandSilhouttes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"),
                column: "ConcurrencyStamp",
                value: "33185f6c-0da2-426a-8b0b-861745df5f69");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"),
                column: "ConcurrencyStamp",
                value: "e53b5f26-1bdc-404b-8e82-3cf31bc3d8a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"),
                column: "ConcurrencyStamp",
                value: "4c3a5f1d-ac82-4563-8173-024a06927278");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "355bf84b-ba03-4edd-9e7d-0be89a320758", "AQAAAAEAACcQAAAAEPeV3J2JKz8FVo3oIr3Yl2EHOPn9u9nJHvLmgxX3qd+4yLmBeMyJofxIO/vVP7lQTw==", "3e7d7753-e4fc-4b3f-b19b-9e8dedc40615" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "156dce51-41f6-45b4-ba85-16d8b6d0f9f8", "AQAAAAEAACcQAAAAEBVk7Rmml/LzTuzvjsl8dNdV8EzANpW3/wSnpnjEFTrucqIMZiQg9dvYVQmNH9wpQA==", "f97998d8-4c91-4f7c-b8de-cf3b620db45e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fff8fc1-61dd-4e6c-8898-e91f98262f1c", "AQAAAAEAACcQAAAAEJSfRaxIiP2cLBHBzWXVSH1gG3zRVA3snmszK181eNioh+8pexFe+WJS6gMLHLO0Bw==", "a3e42426-33b9-4eb2-8031-a8c75ddfbe67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14562238-17b5-4724-a516-0fbf636cfcb8", "AQAAAAEAACcQAAAAEGvJOA7iBTQLyw5tfruK/vsMfhsJdx9S3XEDpS/XTo/t3vD+5FnrOp4X/qAh5o6jjg==", "ca404b26-e865-4fa5-8184-4150ae4706f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19dc8430-b9d4-411a-81ce-c21ec5729b6b", "AQAAAAEAACcQAAAAEKq82n7FCWUY1z8vsMYaQlWTweEB8rt+uht2W7ZSSQajBp/nkVCTZedvYbLp5s5oiw==", "8a61e063-201f-4e4e-84ad-6e00b197e0a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2a0f4a3-1ada-4bef-8f22-3ba665d8c78c", "AQAAAAEAACcQAAAAENv9jEZn6Ksxr0Vq9z2jguyGJsRknXqbXQ+P6FlhD9A2hlzpgzVfgcjHjpcNKQjxIw==", "83bd16fd-7a32-4ce3-afb2-72871d3b3893" });

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Adidas",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Fear of God Essentials",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Nike",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Supreme",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[,]
                {
                    { "air-jordan-1-retro-high-og-ps-seafoam-1.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-2.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-3.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-4.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-5.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-6.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-7.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-8.jpeg", 10 }
                });

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(590), 1, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(590), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(592), 2, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(592), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(593), 3, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(593), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 326.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(594), 4, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(594), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 540.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(595), 5, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(595), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 675.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(596), 6, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(596), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 568.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(597), 7, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(597), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 229.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(598), 8, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(598), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(600), 9, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(599), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 223.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(601), 10, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(601), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 342.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(602), 11, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(602), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 311.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(603), 12, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(603), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(604), 13, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(604), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 319.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(605), 14, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 318.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(606), 15, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(606), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 318.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(607), 16, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(607), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 325.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(608), 17, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(608), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 331.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(609), 18, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(609), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(610), 19, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(610), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 222.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(611), 20, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(611), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 236.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(612), 21, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(612), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 240.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(613), 22, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(613), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 145.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(614), 23, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(614), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(615), 24, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(615), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(618), 25, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(617), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(619), 26, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(618), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(620), 27, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(619), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(621), 28, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(620), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 189.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(622), 29, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(621), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(623), 30, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(622), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(624), 31, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(623), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 209.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(625), 32, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(625), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(626), 33, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(626), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(627), 34, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(627), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 390.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(628), 35, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(628), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 466.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(629), 36, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(629), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(630), 37, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(630), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 146.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(631), 38, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(631), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 140.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(632), 39, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(632), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(634), 40, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(633), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 209.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(634), 41, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(634), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 198.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(636), 42, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(635), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(637), 43, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(636), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(637), 44, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(637), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 140.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(638), 45, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(638), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(639), 46, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(639), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(640), 47, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(640), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 102.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(641), 48, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(641), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 229.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(642), 49, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(643), 50, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(643), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(644), 51, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(645), 52, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(645), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 237.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(646), 53, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 202.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(647), 54, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(647), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 185.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(649), 55, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(649), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(650), 56, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(650), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 75.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(651), 57, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(652), 58, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(652), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 259.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(653), 59, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(653), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 244.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(654), 60, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(654), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(655), 61, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(655), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 483.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(656), 62, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(656), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(657), 63, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(657), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 564.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(658), 64, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(658), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(659), 65, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(659), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(660), 66, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(660), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 155.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(661), 67, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(661), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 745.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(662), 68, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(662), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 740.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(663), 69, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(663), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1718.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(664), 70, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(664), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(665), 71, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(665), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(666), 72, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(666), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 360.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(668), 73, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(667), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 235.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(669), 74, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(668), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(670), 75, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(669), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(671), 76, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(670), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 775.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(672), 77, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(671), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(673), 78, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(673), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 780.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(674), 79, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(674), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 729.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(675), 80, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(675), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 895.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(676), 81, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(676), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(677), 82, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(677), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(678), 83, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(678), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(679), 84, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(679), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 159.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(680), 85, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(680), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 137.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(681), 86, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(681), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(682), 87, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(682), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 124.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(683), 88, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(683), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(684), 89, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(684), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(685), 90, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(685), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 203.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(686), 91, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(686), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 201.0 },
                    { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(687), 92, new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(687), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 194.0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverImage", "CreatedAt", "Name" },
                values: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-1.jpeg", new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8749), "Air Jordan 1 Retro High OG PS 'Seafoam'" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 508, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(313));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-1.jpeg", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-2.jpeg", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-3.jpeg", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-4.jpeg", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-5.jpeg", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-6.jpeg", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-7.jpeg", 10 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-8.jpeg", 10 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(590), 1 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(592), 2 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(593), 3 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(594), 4 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(595), 5 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(596), 6 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(597), 7 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(598), 8 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(600), 9 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(601), 10 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(602), 11 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(603), 12 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(604), 13 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(605), 14 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(606), 15 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(607), 16 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(608), 17 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(609), 18 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(610), 19 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(611), 20 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(612), 21 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(613), 22 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(614), 23 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(615), 24 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(618), 25 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(619), 26 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(620), 27 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(621), 28 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(622), 29 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(623), 30 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(624), 31 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(625), 32 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(626), 33 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(627), 34 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(628), 35 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(629), 36 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(630), 37 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(631), 38 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(632), 39 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(634), 40 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(634), 41 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(636), 42 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(637), 43 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(637), 44 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(638), 45 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(639), 46 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(640), 47 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(641), 48 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(642), 49 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(643), 50 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(644), 51 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(645), 52 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(646), 53 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(647), 54 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(649), 55 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(650), 56 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(651), 57 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(652), 58 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(653), 59 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(654), 60 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(655), 61 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(656), 62 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(657), 63 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(658), 64 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(659), 65 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(660), 66 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(661), 67 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(662), 68 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(663), 69 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(664), 70 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(665), 71 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(666), 72 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(668), 73 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(669), 74 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(670), 75 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(671), 76 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(672), 77 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(673), 78 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(674), 79 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(675), 80 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(676), 81 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(677), 82 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(678), 83 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(679), 84 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(680), 85 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(681), 86 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(682), 87 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(683), 88 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(684), 89 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(685), 90 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(686), 91 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 10, 35, 36, 509, DateTimeKind.Local).AddTicks(687), 92 });

            migrationBuilder.DropColumn(
                name: "Type",
                table: "BrandSilhouttes");

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"),
                column: "ConcurrencyStamp",
                value: "40ea5d74-d817-4946-8e5c-686e914ff1ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"),
                column: "ConcurrencyStamp",
                value: "8f3b9fe6-30e9-4059-8cce-9b41d6a40ea8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"),
                column: "ConcurrencyStamp",
                value: "2a7d7876-8a4a-4f0d-b431-a08e27065872");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75b07713-cf07-4338-97db-b24629a7920f", "AQAAAAEAACcQAAAAEACW2JN9xFmmHGdFhXqeyssshykwjxBk0K1teNCIKlbgpjavjvPvEWdEUtw5La4w+g==", "32b4c956-ffdc-452b-b67a-ea266fe3d4d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd852cc4-6004-4d1a-a0fe-8f33dc47d3e8", "AQAAAAEAACcQAAAAEJynlQWTRYDpdA6NvWnQ4gBtU9CcZvGrqGNsH492HH9DRSwGp1K80MdyXjV3AJEJvw==", "e7ba0df3-d74a-4213-9ca3-9ce2bbd12687" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1515f13-ccb6-4b84-8584-c0ceb53b851e", "AQAAAAEAACcQAAAAEN3MpoyaWjA3L0L7v3zTaQK5ON1lzJCyIxam3MpXvNs4AyzAJ58OT97AviVHzCRadw==", "c5e76584-2b29-474c-8caf-952ae78c17d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d92b731-6c5f-4b97-9de1-89f0f9e7570f", "AQAAAAEAACcQAAAAEJHTHfuMjEq80eL5SMglT18kBjDNm5RN72v0SHGbYHx3WLdILhwLWgvX6+4gCzcVEw==", "e957887c-b0b3-49a7-bea5-2d2f3a12ddea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e4d8735-6ed8-430c-80f8-d6592fac2352", "AQAAAAEAACcQAAAAEJXnnWmLVmCPkl//GTHoHwEZwkZ+IGtYZakAWI0bkwW+sv5uYxFdJ+0tpQ5vBi6/gg==", "372cbc7e-38b3-4873-acb7-05019e9dd6dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1537bfd4-9e3e-4115-8fbe-a57bc0257f6a", "AQAAAAEAACcQAAAAEPwSBF+olHKBuqcxw9nFJ2RrvIjjEJMyBHcEswA/yalmCxY8Rt5syltMsH596J0eTg==", "cde366bc-072b-4e3a-80c2-62cd8d85a747" });

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Adidas",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Fear of God Essentials",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Nike",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Supreme",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[,]
                {
                    { "air-jordan-1-retro-high-og-ps-seafoam-1", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-2", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-3", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-4", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-5", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-6", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-7", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-8", 10 }
                });

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2758));

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
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2802), 11, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2802), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 311.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
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
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2867), 42, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2867), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226.0 },
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
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2879), 53, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2879), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 202.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
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
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2911), 84, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2911), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 159.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2912), 85, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2912), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 137.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2914), 86, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2915), 87, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2914), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 124.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2916), 88, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2915), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2917), 89, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2916), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2918), 90, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2917), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 203.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2919), 91, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2918), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 201.0 },
                    { new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2920), 92, new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2919), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 194.0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CoverImage", "CreatedAt", "Name" },
                values: new object[] { "air-jordan-1-retro-high-og-ps-seafoam-1", new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1136), " " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 2, 23, 58, 37, 954, DateTimeKind.Local).AddTicks(2543));
        }
    }
}
