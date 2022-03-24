using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class updatedataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: "fe934331-5f05-4324-869f-0b25eefcae0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"),
                column: "ConcurrencyStamp",
                value: "4603b92b-3522-4250-b91a-8c86930b2bc2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"),
                column: "ConcurrencyStamp",
                value: "9b7ab705-fafb-44a3-8944-f7cb1efb1de2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c58eb400-6aeb-4d3e-9590-2f4f0e6713b2", "AQAAAAEAACcQAAAAEJ8Vn3+5t87QFIti+EJkH0sMfj9GKLeesq31Ue5Kj1pQ7kVow1/5VO0dNsSG/ARnhg==", "fd5559da-b495-4f60-a5cb-9da91861c7e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08fdc3bb-ab5a-4393-a9e8-b9ac6cbe55a0", "AQAAAAEAACcQAAAAENFrQ8l6w6tVMKAKAS/t+bD1wbRT40na3VCIXkrT9P2aQFmzN/DJsuI/QTnHOs8XOg==", "79f2a41e-422f-49fb-8cd2-82ffc340092e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06da6a44-c4f5-4a7d-98df-886c85f9da8a", "AQAAAAEAACcQAAAAEMcfqyfQIbAim1Ujqo6/WsyfGKSc1AwwtaWQi8Fw6E7bArPBjJ70PcEHWlvlQ1ddHg==", "f5251bab-b01e-4bde-b4b5-8e291f0c1fe6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f3e2bf-338d-4e51-a3f4-703130961bd7", "AQAAAAEAACcQAAAAEMvdjPhPzuEaRwHJJT8h/3GJYDVhXKHFh33wQLPpf4YHFYHkvFVHCcVhx6JH0CyKhw==", "3d38ccf3-8dac-43cb-9334-35c792858f8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74dad2c8-a093-4a1b-b4d8-05057d1c9bce", "AQAAAAEAACcQAAAAEMDakjHCYw6HWz3J6yuMZzmFyC19ZlPUaq8fNuLY1yc2CSze0JCZaUbamrZAkWy73g==", "e16db7c4-a7e6-44d8-9d22-0810966d9b35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c014a2b-b904-43bb-a898-1d90678a3611", "AQAAAAEAACcQAAAAEFn5ebkigVA5uPGwRVZxpVQR6PCvLKP5r+g0WuGJ4O3D3ZEGNRXndSR9EZ3wL5DDCA==", "d648fbc1-8728-4227-b209-566341e5a7ce" });

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Adidas",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 1",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 11",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 4",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 5",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan 6",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Fear of God Essentials",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Kyrie 5",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "LeBron 18",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Little Posite One",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Nike",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Supreme",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Ultra 4D",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy 350",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy 450",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy 700",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy Foam Runner",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy Knit Runner",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Zoom KD 12",
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9806), 1, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9805), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9807), 2, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9807), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9809), 3, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9809), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 326.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9810), 4, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9810), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 540.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9811), 5, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 675.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9812), 6, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9812), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 568.0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Color", "CoverImage", "CreatedAt", "Description", "ModifiedAt", "Name", "Releasedate", "Type", "UserType", "Wallpaper" },
                values: new object[,]
                {
                    { 3, "LifeStyle", "Yellow", "yeezy-foam-runner-ochre-1.jpg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6936), "The adidas Yeezy Foam Runner ‘Ochre’ complements its futuristic aesthetic with a subdued, monochromatic finish. A dark beige hue suffuses the one-piece foam build, featuring ventilation ports of varying shapes and dimensions that enhance breathability while adding depth to the slip-on’s flowing lines. ‘FOAM RNNR’ is debossed on the interior collar, alongside the shoe size and ‘Made in USA’ branding. Underfoot, the outsole features a wavy traction pattern for reliable grip.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Foam Runner 'Ochre'", new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 4, "LifeStyle", "Black", "yeezy-450-dark-slate-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(6985), "The adidas Yeezy 450 ‘Dark Slate’ delivers a blacked-out iteration of Kanye West’s boundary-pushing silhouette. Stripped of color and exterior branding, the knit upper is secured with an integrated lacing system and topped with an elastic, sock-like cuff. In lieu of a traditional midsole, the rubber outsole sprouts tapered appendages that wrap up the heel and side panels of the deconstructed build, providing support and enhanced durability within its grasp.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy 450 'Dark Slate'", new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 5, "LifeStyle", "Black", "Yeezy-Boost-350-V2-Mono-Cinder-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7032), "Launching as part of a four-piece ‘Mono’ pack, the adidas Yeezy Boost 350 V2 ‘Mono Cinder’ applies a black-out finish to the lifestyle sneaker. The revised design features an upper crafted from monofilament mesh, reinforced with an interior cage and accented with a tonal lateral side stripe. A webbing pull tab at the heel allows the sock-like build to be easily slipped on and off. The stealthy palette extends to the midsole, featuring wrapped Boost cushioning that runs the length of the rubber outsole. This shoe released exclusively on Yeezy Supply.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Boost 350 V2 'Mono Cinder'", new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 6, "LifeStyle", "Blue", "air-jordan-1-retro-high-og-university-blue-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7083), "The Air Jordan 1 Retro High OG ‘University Blue’ makes use of a familiar palette that gives the nod to Michael Jordan’s UNC alma mater. The all-leather upper features a white base with powder blue overlays and a black signature Swoosh. Matching black accents make their way to the collar, tongue tag and printed Wings logo on the lateral collar flap. A brighter shade of blue is applied to the standard AJ1 outsole, featuring multi-directional traction and a pivot point under the forefoot.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 1 Retro High OG 'University Blue'", new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 7, "LifeStyle", "Yellow", "air-jordan-4-retro-lightning-2021-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7130), "The 2021 edition of the Air Jordan 4 Retro ‘Lightning’ resurrects a highly coveted colorway that originally launched in 2006 alongside an accompanying ‘Thunder’ colorway, both of which were inspired by Michael Jordan’s Motorsports team. A bright yellow hue floods the nubuck upper, contrasted by black netting and dark grey structural wings. Matching grey accents land on the woven tongue tag, interior tongue and Jumpman branding at the heel. A white PU midsole, enhanced with visible Air sole cushioning, rides on a dark grey herringbone rubber outsole.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 4 Retro 'Lightning' 2021'", new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 8, "LifeStyle", "Red", "air-jordan-5-retro-gs-raging-bull-2021-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7217), "The 2021 reissue of the Air Jordan 5 Retro ‘Raging Bull’ brings back a beloved colorway originally released as one-half of 2009’s Air Jordan 5 Raging Bulls Pack. The shoe’s defining feature is a plush Varsity Red suede upper, equipped with black eyelets and a Jumpman-branded reflective silver tongue. The heel overlay displays a second Jumpman logo and an embroidered 23 on the lateral side. A visible Nike Air heel unit enhances the polyurethane midsole, accented with red-tipped shark tooth detailing and supported by an icy translucent outsole.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 5 Retro 'Raging Bull' 2021'", new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 9, "LifeStyle", "Red", "air-jordan-11-retro-bred-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7265), "The Air Jordan 11 Retro 'Bred' 2019 brings back an original colorway initially debuted in 1995. The Tinker Hatfield-designed silhouette features Chicago Bulls colors, with black mesh on the upper sitting atop shiny black patent leather. A white midsole melds nicely with a translucent Varsity Red outsole, and is the same colorway that Michael Jordan wore during the 1996 NBA championship playoff run. This retro was distributed in December 2019 with OG detailing, including high-cut patent leather, signature Jumpman branding and MJ's number 23 stamped on the heel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 11 Retro 'Bred' 2019", new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 10, "LifeStyle", "Green", "air-jordan-1-retro-high-og-ps-seafoam-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7312), "Crafted for little kids, the Air Jordan 1 Retro High OG PS ‘Seafoam’ updates the iconic silhouette with a two-tone palette geared for the warm weather months. The upper is constructed from clean white leather with contrasting nubuck overlays in a pale green finish. The same pastel hue is repeated on the signature Swoosh, Nike branded tongue tag and durable rubber outsole. Woven white laces are outlined in reddish bronze for an unexpected pop of contrasting color.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 1 Retro High OG PS 'Seafoam'", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Youth", null },
                    { 11, "LifeStyle", "Blue", "air-jordan-1-retro-high-og-dark-marina-blue-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7382), "The Air Jordan 1 Retro High OG ‘Dark Marina Blue’ dresses the iconic silhouette in classic two-tone color blocking. The all-leather upper features a black base with contrasting dark blue overlays along the forefoot, heel, collar and eyestay. A matching blue Swoosh is accompanied by a Jordan Wings logo stamped in black on the lateral collar flap. Atop the nylon tongue, a woven Nike Air tag nods to the shoe’s retro cushioning technology: an Air-sole unit encapsulated in polyurethane nestled in the heel of the rubber cupsole.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 1 Retro High OG 'Dark Marina Blue'", new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 12, "LifeStyle", "Tan", "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7432), "The stash pouch makes a repeat appearance on the lateral collar, while new zippered detailing is added to the medial side. Mismatched Nike Air and Cactus Jack branding adorns the heel of the left and right shoe, with additional graphics on the midsole, outsole, tongue and lace lock.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis Scott x Air Jordan 6 Retro 'British Khaki'", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 13, "Running", "Black", "Ultra-4D-OG-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7478), "The adidas Ultra 4D ‘OG’ borrows a familiar color scheme initially featured on the UltraBoost release from 2015. This pair replaces the signature Boost cushioning of the original with a futuristic adidas 4D midsole, using a lattice structure made with a blend of liquid resin, light and oxygen. Up top, a matching black knit build is reinforced with a tonal midfoot cage and contrasting purple heel counter marked with Ultra 4D branding.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'OG'", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 14, "Running", "Black", "ultra-4d-5-0-carbon-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7545), "The adidas Ultra 4D 5.0 ‘Carbon’ delivers a monotone take on a performance runner built on the brand’s revolutionary 3D-printed midsole, featuring a unique lattice structure crafted from a blend of light, oxygen and liquid resin. Up top, breathable Primeknit weaves together black and grey fibers to create unique patterns around the toe box and collar. Three-stripe branding is integrated into the midfoot cage, which works in tandem with a molded heel counter to provide added stability and support.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 5.0 'Carbon'", new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 15, "Running", "Grey", "ultra-4d-grey-pink-gradient-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7593), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'Grey Pink Gradient'", new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 16, "Running", "White", "Ultra-4D-Chalk-White-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7680), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'Chalk White'", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 17, "Running", "Cream", "ultra-4d-lemon-twist.png", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7727), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'Lemon Twist'", new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 18, "Basketball", "Cream", "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7773), "Designed in partnership with the influential Tokyo-based retailer, the atmos x Nike LeBron 18 Low ‘Cherry Blossom’ showcases a spring-ready design, highlighted by a Swoosh formed with pink embroidered florals. The pastel hue is repeated on the sneaker’s molded eyelets and TPU heel counter, as well as a multicolor geometric print that enlivens the textile upper. The low-top sits on a cushy React foam midsole with a large-volume Max Air unit nestled under the heel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "atmos x LeBron 18 Low 'Sakura'", new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 19, "Basketball", "Orange", "Little-Posite-One-GS-Twilight-Pulse-1.png", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7847), "The Nike Little Posite One GS ‘Twilight Pulse’ dresses Penny Hardaway’s signature shoe with a matte black finish on the molded synthetic upper. Metallic blue accents deliver contrasting color on the eyestay and collar trim, as does the bright orange shank plate integrated into the translucent sole unit. A mesh tongue and heel inlay provide breathable comfort while the attached pull loops are included for easy on and off.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little Posite One GS 'Twilight Pulse'", new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Youth", null },
                    { 20, "Basketball", "Blue", "little-posite-one-xx-royal-1.png", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7896), "Nike released a grade school exclusive to celebrate the 20th-anniversary of the Nike Air Foamposite One. The Little Posite One XX GS 'Royal' features a shiny Royal Blue Foamposite shell with black suede details on the eyestay and collar. The sneaker also boasts a carbon fiber midfoot arch, a mini white Swoosh on the forefoot, an icy blue translucent outsole, and a mesh inner sleeve for breathability and comfort.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little Posite One XX GS 'Royal'", new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Youth", null },
                    { 21, "Basketball", "White", "kyrie-5-ep-have-a-nike-day-1.png", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(7942), "A special edition of Kyrie Irving’s fifth model in his signature line, the Nike Kyrie 5 basketball shoe was one of the sneakers selected to be part of Nike’s celebratory 'Have A Nike Day' collection. Released in June 2019, the shoe is comprised of an engineered mesh upper for breathable, natural movement. The exterior is fitted with denim overlays, multicolored accents and Nike’s retro smiley face logo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyrie 5 'Have A Nike Day'", new DateTime(2019, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 22, "Basketball", "White", "zoom-kd-12-wolf-grey-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8083), "Doused in a 'Wolf Grey' colorway, the July 2019 Nike's Zoom KD 12 features a breathable and lightweight mesh upper with Flywire for lock-down, emulating the 'worn-in' feel NBA star Kevin Durant prefers. The shoe eliminates the more-typical strobel layer between the upper by stitching an iridescent, full-length Zoom Air unit directly to the upper increasing energy-return and spring on the court.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zoom KD 12 'Wolf Grey'", new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 23, "Outerwear", "Red", "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8134), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x The North Face Faux Fur Nuptse Jacket 'Red'", new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 24, "Outerwear", "Red", "supreme-x-nike-half-zip-hooded-sweatshirt-white-2.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8295), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x Nike Half Zip Hooded Sweatshirt 'White'", new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 25, "Outerwear", "Multi-Color", "supreme-saint-michael-fleece-jacket-white-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8346), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme Saint Michael Fleece Jacket 'White'", new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 26, "Outerwear", "Gold", "supreme-x-the-north-face-cargo-jacket-gold.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8393), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x The North Face Cargo Jacket 'Gold'", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 27, "Outerwear", "Black", "supreme-x-the-north-face-s-logo-mountain-jacket-black-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8439), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x The North Face S Logo Mountain Jacket 'Black'", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 28, "Tops", "Black", "fear-of-god-essentials-kids-short-sleeve-polo-stretch-limo.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8485), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids Short-Sleeve Polo 'Stretch Limo'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 29, "Outerwear", "Black", "fear-of-god-essentials-kids-pullover-hoodie-stretch-limo.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8558), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids Pullover Hoodie 'Stretch Limo'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 30, "Bottoms", "Black", "fear-of-god-essentials-kids-sweatpant-stretch-limo.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8606), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids Sweatpant 'Stretch Limo'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 31, "Accessories", "Brown", "fear-of-god-essentials-rc-9fifty-cap-black-1.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8708), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials RC 9FIFTY Cap 'Black'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 32, "Outerwear", "Fear of God Essentials", "fear-of-god-essentials-x-mr-porter-exclusive-hoodie-vicunia.jpeg", new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(8785), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids x Mr. Porter Exclusive Hoodie 'Vicunia'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null }
                });

            migrationBuilder.InsertData(
                table: "BrandSilhouetteProduct",
                columns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                values: new object[,]
                {
                    { "Adidas", 3 },
                    { "Adidas", 4 },
                    { "Adidas", 5 },
                    { "Adidas", 13 },
                    { "Adidas", 14 },
                    { "Adidas", 15 },
                    { "Adidas", 16 },
                    { "Adidas", 17 },
                    { "Air Jordan", 6 },
                    { "Air Jordan", 7 },
                    { "Air Jordan", 8 },
                    { "Air Jordan", 9 },
                    { "Air Jordan", 10 },
                    { "Air Jordan", 11 },
                    { "Air Jordan", 12 },
                    { "Air Jordan 1", 6 },
                    { "Air Jordan 1", 10 },
                    { "Air Jordan 1", 11 },
                    { "Air Jordan 11", 9 },
                    { "Air Jordan 4", 7 },
                    { "Air Jordan 5", 8 },
                    { "Air Jordan 6", 12 },
                    { "Fear of God Essentials", 28 },
                    { "Fear of God Essentials", 29 },
                    { "Fear of God Essentials", 30 },
                    { "Fear of God Essentials", 31 },
                    { "Fear of God Essentials", 32 },
                    { "Kyrie 5", 21 },
                    { "LeBron 18", 18 },
                    { "Little Posite One", 19 },
                    { "Little Posite One", 20 },
                    { "Nike", 6 },
                    { "Nike", 7 },
                    { "Nike", 8 },
                    { "Nike", 9 },
                    { "Nike", 10 },
                    { "Nike", 11 },
                    { "Nike", 12 },
                    { "Nike", 18 },
                    { "Nike", 19 },
                    { "Nike", 20 },
                    { "Nike", 21 }
                });

            migrationBuilder.InsertData(
                table: "BrandSilhouetteProduct",
                columns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                values: new object[,]
                {
                    { "Nike", 22 },
                    { "Supreme", 23 },
                    { "Supreme", 24 },
                    { "Supreme", 25 },
                    { "Supreme", 26 },
                    { "Supreme", 27 },
                    { "Ultra 4D", 13 },
                    { "Ultra 4D", 14 },
                    { "Ultra 4D", 15 },
                    { "Ultra 4D", 16 },
                    { "Ultra 4D", 17 },
                    { "Yeezy", 3 },
                    { "Yeezy", 4 },
                    { "Yeezy", 5 },
                    { "Yeezy 350", 5 },
                    { "Yeezy 450", 4 },
                    { "Yeezy Foam Runner", 3 },
                    { "Zoom KD 12", 22 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[,]
                {
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
                    { "air-jordan-1-retro-high-og-ps-seafoam-1.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-2.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-3.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-4.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-5.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-6.jpeg", 10 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[,]
                {
                    { "air-jordan-1-retro-high-og-ps-seafoam-7.jpeg", 10 },
                    { "air-jordan-1-retro-high-og-ps-seafoam-8.jpeg", 10 },
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
                    { 7, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9633), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 100, "8" },
                    { 8, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9634), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 100, "8.5" },
                    { 9, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9635), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 100, "9" },
                    { 10, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9637), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 100, "8" },
                    { 11, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9638), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 100, "8.5" },
                    { 12, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9638), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 100, "9" },
                    { 13, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9639), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "8" },
                    { 14, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9640), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "8.5" },
                    { 15, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9677), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 100, "9" },
                    { 16, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9678), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 100, "8" },
                    { 17, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9679), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 100, "8.5" },
                    { 18, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9680), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 100, "9" },
                    { 19, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9681), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 100, "8" },
                    { 20, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9681), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 100, "8.5" },
                    { 21, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9682), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 100, "9" },
                    { 22, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9683), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 100, "8" },
                    { 23, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9684), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 100, "8.5" },
                    { 24, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9684), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 100, "9" },
                    { 25, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9685), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 100, "8" },
                    { 26, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9686), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 100, "8.5" },
                    { 27, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9687), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 100, "9" },
                    { 28, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9688), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100, "10.5" },
                    { 29, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9689), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100, "11" },
                    { 30, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9689), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 100, "11.5" },
                    { 31, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9691), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 100, "8" },
                    { 32, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9692), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 100, "8.5" },
                    { 33, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9693), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 100, "9" },
                    { 34, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9694), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100, "8" },
                    { 35, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9694), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100, "8.5" },
                    { 36, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9695), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 100, "9" },
                    { 37, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9696), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 100, "8" },
                    { 38, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9696), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 100, "8.5" },
                    { 39, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9697), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 110, "9" },
                    { 40, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9698), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 100, "8" },
                    { 41, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9699), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 100, "8.5" },
                    { 42, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9699), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 110, "9" },
                    { 43, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9700), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 100, "8" },
                    { 44, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 100, "8.5" },
                    { 45, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9702), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 110, "9" }
                });

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "CreatedAt", "ModifiledAt", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { 46, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9702), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 100, "8" },
                    { 47, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9703), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 100, "8.5" },
                    { 48, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9704), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 110, "9" },
                    { 49, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9705), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 100, "8" },
                    { 50, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9705), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 100, "8.5" },
                    { 51, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9706), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 110, "9" },
                    { 52, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9707), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 100, "8" },
                    { 53, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9708), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 100, "8.5" },
                    { 54, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9709), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 110, "9" },
                    { 55, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9710), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 100, "3" },
                    { 56, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9710), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 100, "3.5" },
                    { 57, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 110, "4" },
                    { 58, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9712), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 100, "3" },
                    { 59, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9713), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 100, "3.5" },
                    { 60, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9713), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 110, "4" },
                    { 61, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 100, "8" },
                    { 62, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9715), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 100, "8.5" },
                    { 63, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9715), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 110, "9" },
                    { 64, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9716), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 100, "8" },
                    { 65, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9717), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 100, "8.5" },
                    { 66, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9718), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 155, "9" },
                    { 67, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9718), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 100, "M" },
                    { 68, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9720), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 100, "L" },
                    { 69, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9720), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 155, "XL" },
                    { 70, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9721), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 100, "M" },
                    { 71, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9722), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 100, "L" },
                    { 72, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9723), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 155, "XL" },
                    { 73, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9723), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 100, "M" },
                    { 74, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9725), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 100, "L" },
                    { 75, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9726), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 155, "XL" },
                    { 76, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9726), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 100, "M" },
                    { 77, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9727), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 100, "L" },
                    { 78, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9728), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 100, "M" },
                    { 79, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9729), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 100, "L" },
                    { 80, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9729), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 100, "XL" },
                    { 81, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9730), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 100, "8" },
                    { 82, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 100, "10" },
                    { 83, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, "2/3" },
                    { 84, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9732), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, "4" },
                    { 85, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9733), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 100, "4.5" },
                    { 86, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9733), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 100, "2/3" },
                    { 87, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9734), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 100, "4" }
                });

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "CreatedAt", "ModifiledAt", "ProductId", "Quantity", "Size" },
                values: new object[,]
                {
                    { 88, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9735), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 100, "6" },
                    { 89, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9736), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 100, "One Size" },
                    { 90, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9736), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 100, "4" },
                    { 91, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9737), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 100, "6" },
                    { 92, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9738), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 100, "8" }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9813), 7, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9813), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 229.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9814), 8, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9814), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 221.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9815), 9, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9815), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 223.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9816), 10, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9816), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 342.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9817), 11, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9817), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 311.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9818), 12, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9818), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9819), 13, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9819), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 319.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9820), 14, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9820), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 318.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9821), 15, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9821), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 318.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9823), 16, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9822), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 325.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9823), 17, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9823), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 331.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9824), 18, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9824), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9825), 19, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9825), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 222.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9827), 20, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9826), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 236.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9827), 21, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9827), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 240.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9828), 22, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9828), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 145.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9830), 23, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9829), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9831), 24, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9830), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 141.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9832), 25, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9831), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9834), 26, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9833), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9835), 27, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9834), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9836), 28, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9835), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 189.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9837), 29, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9836), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9838), 30, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9837), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9839), 31, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9838), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 209.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9840), 32, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9839), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9841), 33, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9840), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 210.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9842), 34, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9841), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 390.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9843), 35, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9842), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 466.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9844), 36, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9843), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9845), 37, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9844), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 146.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9846), 38, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9845), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 140.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9847), 39, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9846), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 410.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9848), 40, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9847), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 209.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9849), 41, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9849), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 198.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9850), 42, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9850), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 226.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9851), 43, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9851), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9852), 44, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9852), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 140.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9853), 45, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9853), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 166.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9854), 46, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9854), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9855), 47, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9855), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 102.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9856), 48, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9856), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 229.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[,]
                {
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9858), 49, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9857), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9859), 50, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9858), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9860), 51, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9859), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9861), 52, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9860), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 237.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9862), 53, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9861), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 202.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9863), 54, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9862), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 185.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9864), 55, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9863), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9865), 56, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9864), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 75.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9866), 57, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9865), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9867), 58, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9866), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 259.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9868), 59, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9867), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 244.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9869), 60, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9868), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9870), 61, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9869), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 483.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9871), 62, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9870), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 415.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9872), 63, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9871), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 564.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9873), 64, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9872), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9874), 65, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9873), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 230.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9875), 66, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9874), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 155.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9876), 67, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 745.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9877), 68, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9876), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 740.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9878), 69, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9877), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1718.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9879), 70, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9878), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9881), 71, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9880), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9882), 72, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9881), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 360.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9883), 73, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9882), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 235.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9884), 74, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9883), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9885), 75, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9884), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 384.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9886), 76, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9885), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 775.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9887), 77, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9886), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9888), 78, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9887), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 780.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9889), 79, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9888), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 729.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9889), 80, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9889), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 895.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9891), 81, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9890), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9892), 82, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9891), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9893), 83, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9892), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9894), 84, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9893), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 159.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9897), 85, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9896), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 137.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9898), 86, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9897), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9899), 87, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9898), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 124.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9900), 88, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9899), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 120.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9901), 89, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9900), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.0 },
                    { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9902), 90, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9901), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 203.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9903), 91, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9902), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 201.0 });

            migrationBuilder.InsertData(
                table: "ProductPrices",
                columns: new[] { "EffectTime", "ProductInventoryId", "CreatedAt", "ModifiedAt", "Price" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9904), 92, new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9904), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 194.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 3 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 4 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 5 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 13 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 14 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 15 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 16 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Adidas", 17 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan", 6 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan", 7 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan", 8 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan", 9 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan", 10 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan", 11 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan", 12 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan 1", 6 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan 1", 10 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan 1", 11 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan 11", 9 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan 4", 7 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan 5", 8 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Air Jordan 6", 12 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Fear of God Essentials", 28 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Fear of God Essentials", 29 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Fear of God Essentials", 30 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Fear of God Essentials", 31 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Fear of God Essentials", 32 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Kyrie 5", 21 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "LeBron 18", 18 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Little Posite One", 19 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Little Posite One", 20 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 6 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 7 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 8 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 9 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 10 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 11 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 12 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 18 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 19 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 20 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 21 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Nike", 22 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Supreme", 23 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Supreme", 24 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Supreme", 25 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Supreme", 26 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Supreme", 27 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Ultra 4D", 13 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Ultra 4D", 14 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Ultra 4D", 15 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Ultra 4D", 16 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Ultra 4D", 17 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy", 3 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy", 4 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy", 5 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy 350", 5 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy 450", 4 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Yeezy Foam Runner", 3 });

            migrationBuilder.DeleteData(
                table: "BrandSilhouetteProduct",
                keyColumns: new[] { "BrandSilhouetteNameId", "ProductsId" },
                keyValues: new object[] { "Zoom KD 12", 22 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-foam-runner-ochre-1.jpg", 3 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-foam-runner-ochre-2.jpg", 3 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-foam-runner-ochre-3.jpg", 3 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-foam-runner-ochre-4.jpg", 3 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-foam-runner-ochre-5.jpg", 3 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-foam-runner-ochre-6.jpg", 3 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-foam-runner-ochre-7.jpg", 3 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-foam-runner-ochre-8.jpg", 3 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-1.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-10.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-2.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-3.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-4.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-5.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-6.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-7.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-8.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-450-dark-slate-9.jpeg", 4 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-1.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-10.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-2.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-3.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-4.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-5.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-6.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-7.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-8.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Yeezy-Boost-350-V2-Mono-Cinder-9.jpeg", 5 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-university-blue-1.jpeg", 6 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-university-blue-2.jpeg", 6 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-university-blue-3.jpeg", 6 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-university-blue-4.jpeg", 6 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-university-blue-5.jpeg", 6 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-university-blue-6.jpeg", 6 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-university-blue-7.jpeg", 6 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-university-blue-8.jpeg", 6 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-4-retro-lightning-2021-1.jpeg", 7 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-4-retro-lightning-2021-2.jpeg", 7 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-4-retro-lightning-2021-3.jpeg", 7 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-4-retro-lightning-2021-4.jpeg", 7 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-4-retro-lightning-2021-5.jpeg", 7 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-4-retro-lightning-2021-6.jpeg", 7 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-4-retro-lightning-2021-7.jpeg", 7 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-4-retro-lightning-2021-8.jpeg", 7 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-5-retro-gs-raging-bull-2021-1.jpeg", 8 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-5-retro-gs-raging-bull-2021-2.jpeg", 8 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-5-retro-gs-raging-bull-2021-3.jpeg", 8 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-5-retro-gs-raging-bull-2021-4.jpeg", 8 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-5-retro-gs-raging-bull-2021-5.jpeg", 8 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-5-retro-gs-raging-bull-2021-6.jpeg", 8 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-5-retro-gs-raging-bull-2021-7.jpeg", 8 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-5-retro-gs-raging-bull-2021-8.jpeg", 8 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-11-retro-bred-1.jpeg", 9 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-11-retro-bred-2.jpeg", 9 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-11-retro-bred-3.jpeg", 9 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-11-retro-bred-4.jpeg", 9 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-11-retro-bred-5.jpeg", 9 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-11-retro-bred-6.jpeg", 9 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-11-retro-bred-7.jpeg", 9 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-11-retro-bred-8.jpeg", 9 });

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
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-dark-marina-blue-1.jpeg", 11 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-dark-marina-blue-2.jpeg", 11 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-dark-marina-blue-3.jpeg", 11 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-dark-marina-blue-4.jpeg", 11 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-dark-marina-blue-5.jpeg", 11 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-dark-marina-blue-6.jpeg", 11 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-dark-marina-blue-7.jpeg", 11 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "air-jordan-1-retro-high-og-dark-marina-blue-8.jpeg", 11 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-1.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-10.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-2.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-3.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-4.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-5.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-6.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-7.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-8.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-9.jpeg", 12 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-OG-1.jpeg", 13 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-OG-2.jpeg", 13 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-OG-3.jpeg", 13 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-OG-4.jpeg", 13 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-OG-5.jpeg", 13 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-OG-6.jpeg", 13 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-OG-7.jpeg", 13 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-5-0-carbon-1.jpeg", 14 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-5-0-carbon-2.jpeg", 14 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-5-0-carbon-3.jpeg", 14 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-5-0-carbon-4.jpeg", 14 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-5-0-carbon-5.jpeg", 14 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-5-0-carbon-6.jpeg", 14 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-5-0-carbon-7.jpeg", 14 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-5-0-carbon-8.jpeg", 14 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-grey-pink-gradient-1.jpeg", 15 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-grey-pink-gradient-2.jpeg", 15 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-grey-pink-gradient-3.jpeg", 15 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-grey-pink-gradient-4.jpeg", 15 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-grey-pink-gradient-5.jpeg", 15 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-grey-pink-gradient-6.jpeg", 15 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-grey-pink-gradient-7.jpeg", 15 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "ultra-4d-grey-pink-gradient-8.jpeg", 15 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-Chalk-White-1.jpeg", 16 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-Chalk-White-2.jpeg", 16 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-Chalk-White-3.jpeg", 16 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-Chalk-White-4.jpeg", 16 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-Chalk-White-5.jpeg", 16 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-Chalk-White-6.jpeg", 16 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-Chalk-White-7.jpeg", 16 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Ultra-4D-Chalk-White-8.jpeg", 16 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-10.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-2.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-3.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-4.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-5.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-6.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-7.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-8.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "atmos-x-LeBron 18-Low-'Sakura'-9.jpeg", 18 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "Little-Posite-One-GS-Twilight-Pulse-1.png", 19 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "little-posite-one-xx-royal-1.png", 20 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "kyrie-5-ep-have-a-nike-day-1.png", 21 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "zoom-kd-12-wolf-grey-1.jpeg", 22 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "zoom-kd-12-wolf-grey-2.jpeg", 22 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "zoom-kd-12-wolf-grey-3.jpeg", 22 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "zoom-kd-12-wolf-grey-4.jpeg", 22 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "zoom-kd-12-wolf-grey-5.jpeg", 22 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-1.jpeg", 23 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-2.jpeg", 23 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-3.jpeg", 23 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-x-nike-half-zip-hooded-sweatshirt-white-1.jpeg", 24 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-x-nike-half-zip-hooded-sweatshirt-white-2.jpeg", 24 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-saint-michael-fleece-jacket-white-1.jpeg", 25 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-saint-michael-fleece-jacket-white-2.jpeg", 25 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-saint-michael-fleece-jacket-white-3.jpeg", 25 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-x-the-north-face-cargo-jacket-gold.jpeg", 26 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-x-the-north-face-s-logo-mountain-jacket-black-1.jpeg", 27 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-x-the-north-face-s-logo-mountain-jacket-black-2.jpeg", 27 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "supreme-x-the-north-face-s-logo-mountain-jacket-black-3.jpeg", 27 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "fear-of-god-essentials-kids-short-sleeve-polo-stretch-limo.jpeg", 28 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "fear-of-god-essentials-kids-pullover-hoodie-stretch-limo.jpeg", 29 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "fear-of-god-essentials-kids-sweatpant-stretch-limo.jpeg", 30 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "fear-of-god-essentials-rc-9fifty-cap-black-1.jpeg", 31 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "fear-of-god-essentials-rc-9fifty-cap-black-2.jpeg", 31 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "fear-of-god-essentials-x-mr-porter-exclusive-hoodie-vicunia.jpeg", 32 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9806), 1 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9807), 2 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9809), 3 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9810), 4 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9811), 5 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9812), 6 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9813), 7 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9814), 8 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9815), 9 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9816), 10 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9817), 11 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9818), 12 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9819), 13 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9820), 14 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9821), 15 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9823), 16 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9823), 17 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9824), 18 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9825), 19 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9827), 20 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9827), 21 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9828), 22 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9830), 23 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9831), 24 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9832), 25 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9834), 26 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9835), 27 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9836), 28 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9837), 29 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9838), 30 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9839), 31 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9840), 32 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9841), 33 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9842), 34 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9843), 35 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9844), 36 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9845), 37 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9846), 38 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9847), 39 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9848), 40 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9849), 41 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9850), 42 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9851), 43 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9852), 44 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9853), 45 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9854), 46 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9855), 47 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9856), 48 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9858), 49 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9859), 50 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9860), 51 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9861), 52 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9862), 53 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9863), 54 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9864), 55 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9865), 56 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9866), 57 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9867), 58 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9868), 59 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9869), 60 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9870), 61 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9871), 62 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9872), 63 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9873), 64 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9874), 65 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9875), 66 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9876), 67 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9877), 68 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9878), 69 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9879), 70 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9881), 71 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9882), 72 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9883), 73 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9884), 74 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9885), 75 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9886), 76 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9887), 77 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9888), 78 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9889), 79 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9889), 80 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9891), 81 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9892), 82 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9893), 83 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9894), 84 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9897), 85 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9898), 86 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9899), 87 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9900), 88 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9901), 89 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9902), 90 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9903), 91 });

            migrationBuilder.DeleteData(
                table: "ProductPrices",
                keyColumns: new[] { "EffectTime", "ProductInventoryId" },
                keyValues: new object[] { new DateTime(2022, 3, 24, 20, 5, 9, 298, DateTimeKind.Local).AddTicks(9904), 92 });

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

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
    }
}
