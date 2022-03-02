using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityRole<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole<Guid>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.InsertData(
                table: "BrandSilhouttes",
                columns: new[] { "NameId", "CreatedAt", "Icon", "ModifiedAt", "Story" },
                values: new object[,]
                {
                    { "Adidas", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(128), "adidas.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adi Dassler founded adidas in 1949 in Herzogenaurach, Germany. Building on the reputation of the brand’s spiked running shoes and football cleats, Dassler turned adidas into a global icon, redefining sneakers and apparel in the process. Today, adidas is considered one of the world’s most influential brands, responsible for the Stan Smith, Yeezy sneakers and more." },
                    { "Air Jordan", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(140), "jordan.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In 1984, Nike unveiled the Air Jordan 1, a basketball sneaker designed by Peter Moore for a young Michael Jordan. The iconic silhouette transcended sneakers and sports, altering the trajectory of style forever. Today, Michael Jordan’s namesake brand continues to inspire sportswear and style movements around the world through new releases, retro drops and unexpected collaborations." },
                    { "Fear of God Essentials", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(142), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In 2018, Jerry Lorenzo launched Fear of God Essentials, a pared-back version of Fear of God. Each seasonal collection brings the line’s concept into sharper focus, uniting elevated sportswear basics with subdued shades and minimal branding." },
                    { "Nike", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(138), "nike.png", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Founded by Bill Bowerman and Phil Knight in 1964, Nike is synonymous with performance and innovation. Alongside its apparel offerings, the sportswear giant is responsible for a number of iconic sneakers, including the Air Force 1, the Air Max franchise and more. Today, Nike is among the world’s most recognized brands, identified by its wordmark and Swoosh logo." },
                    { "Supreme", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(140), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Founded by James Jebbia in 1994, Supreme is a New York-based skate brand known for its subcultural references and controversial graphics. Today, Supreme is considered one of style’s most influential voices, blurring the lines between streetwear and luxury through collaborations with artists, fashion houses and sneaker brands." },
                    { "Yeezy", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(141), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In late 2013, Kanye West and adidas announced their forthcoming partnership. In 2015, the two delivered on this news, arriving in the form of Yeezy Season 1, a collection of sneakers and apparel debuted at New York Fashion Week. Since the first collection, Yeezy has influenced style movements worldwide." }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole<Guid>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0151bf94-13d6-4cb7-a815-43cdb359413b"), "857f5778-6ecd-4c05-a647-a6b321522977", "admin", "admin" },
                    { new Guid("b610dd6a-d83e-4937-9e7c-700512654ca2"), "a8859393-1942-45a2-b1fc-39f561af2d0b", "SuperAdmin", "superadmin" },
                    { new Guid("bb64cbe4-5757-40ea-8533-980a148e3369"), "22002a93-55a3-4ac0-a3db-f1ab09836a3d", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "CartSessionId", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"), 0, null, "c5d9a2b9-c09d-4a58-869f-9090f675fdfc", "superadmin@superadmin.com", false, false, null, null, null, "AQAAAAEAACcQAAAAENVvoZ6nbwGZ9D5/VZSTpHBwRz1kZVcEiiW6YA5Znb5TUCuUuxIdMeQRf7k2IrP2gg==", null, false, "edbe5209-38e3-42fd-8a16-6a5a45d737f5", false, "superAdmin" },
                    { new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"), 0, null, "de9ab822-cf4e-4bc5-893a-a22c4a372429", "admin@admin.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEK21jruPuxwHC/YEJVT7FEs+UKVIQCMP6Y6Bo3IfcM2fYsJFpI8tfjKhvUkGJQtRwQ==", null, false, "2465a7b7-6aa4-447d-9c39-5e2a3a067a6c", false, "admin" },
                    { new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"), 0, null, "4f551e29-6a22-4b18-891d-90a223f25290", "customer1@customer1.com", false, false, null, null, null, "AQAAAAEAACcQAAAAED880rmUyKcpMBZSPd6676gtMfClZgMXFpVVvv7zX7QFCycDLO7ZyWLg9zxR+oMMhw==", null, false, "4aab91f0-efd9-4f9b-af13-ce80ce8ac7dc", false, "customer1" },
                    { new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"), 0, null, "923a4eec-26a2-4bb2-9aa5-20ee0a6c7eca", "user@user.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECohSneJ5eMW3GYXlQKyGg4KCGHgkwoqV7Tz/YmtuBYBSLOkuk+D6ASr9LFNr9J7YQ==", null, false, "275f2bca-efda-4c10-a24a-b9d1d74abdb5", false, "defaultuser" },
                    { new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"), 0, null, "8a2088e2-9c4d-4abf-bfab-27894d999086", "customer3@customer3.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEDMutAk1/QuMThXMBhCgf3HIVtUoF41rfQEyOR/liEG3SotMqF0eOzJ2S1VVogdsZQ==", null, false, "76ba6b9b-de42-41ce-b783-b1783a52588c", false, "customer3" },
                    { new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"), 0, null, "94bc7c9f-5fa6-4d90-be14-d7b411761364", "customer2@customer2.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEJizwbd1A2M907TlWBONyoDCr30hj9rGjgWU1Qcyno2z7rLsLY8Q9gh/tP0YFdesHw==", null, false, "1a60c393-7a9a-4c85-abdb-21410cba4d17", false, "customer2" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
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
                    { 1, "Yeezy", "Boots", "Tan", "yeezy-boost-700-mauve-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(260), "The adidas Yeezy Boost 700 V2 ‘Mauve’ brings back a popular colorway first seen on a Yeezy Boost 700 release from 2018. The sneaker’s titular hue is executed on a textured mesh upper with arcing no-sew skins along the quarter panel and greenish-grey suede overlays throughout. Responsive cushioning comes courtesy of a full-length drop-in Boost midsole, housed within a sculpted polyurethane carrier. Underfoot, a herringbone-traction rubber outsole provides optimal grip.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Boost 700 V2 'Mauve'", new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 2, "Yeezy", "LifeStyle", "Sulfur", "yeezy-knit-runner-sulfur-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(691), "The adidas Yeezy Knit Runner ‘Sulfur’ delivers the debut colorway of Kanye West’s sock-like silhouette, which launched exclusively through the artist’s Yeezy Supply site. The fully knit build, rendered in a neutral tan shade with a contrasting mustard yellow finish throughout the majority of the upper, utilizes slip-on construction devoid of exterior branding. Embellishments are limited to sizing information stamped on the lateral collar. The sneaker rides on a durable rubber outsole in a matching yellow finish, featuring a modified herringbone tread and adidas branding under the heel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Knit Runner 'Sulfur'", new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 3, "Yeezy", "LifeStyle", "Yellow", "yeezy-foam-runner-ochre-1.jpg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(781), "The adidas Yeezy Foam Runner ‘Ochre’ complements its futuristic aesthetic with a subdued, monochromatic finish. A dark beige hue suffuses the one-piece foam build, featuring ventilation ports of varying shapes and dimensions that enhance breathability while adding depth to the slip-on’s flowing lines. ‘FOAM RNNR’ is debossed on the interior collar, alongside the shoe size and ‘Made in USA’ branding. Underfoot, the outsole features a wavy traction pattern for reliable grip.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Foam Runner 'Ochre'", new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 4, "Yeezy", "LifeStyle", "Black", "yeezy-450-dark-slate-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(830), "The adidas Yeezy 450 ‘Dark Slate’ delivers a blacked-out iteration of Kanye West’s boundary-pushing silhouette. Stripped of color and exterior branding, the knit upper is secured with an integrated lacing system and topped with an elastic, sock-like cuff. In lieu of a traditional midsole, the rubber outsole sprouts tapered appendages that wrap up the heel and side panels of the deconstructed build, providing support and enhanced durability within its grasp.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy 450 'Dark Slate'", new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 5, "Yeezy", "LifeStyle", "Black", "Yeezy-Boost-350-V2-Mono-Cinder-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(880), "Launching as part of a four-piece ‘Mono’ pack, the adidas Yeezy Boost 350 V2 ‘Mono Cinder’ applies a black-out finish to the lifestyle sneaker. The revised design features an upper crafted from monofilament mesh, reinforced with an interior cage and accented with a tonal lateral side stripe. A webbing pull tab at the heel allows the sock-like build to be easily slipped on and off. The stealthy palette extends to the midsole, featuring wrapped Boost cushioning that runs the length of the rubber outsole. This shoe released exclusively on Yeezy Supply.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeezy Boost 350 V2 'Mono Cinder'", new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 6, "Air Jordan", "LifeStyle", "Blue", "air-jordan-1-retro-high-og-university-blue-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(927), "The Air Jordan 1 Retro High OG ‘University Blue’ makes use of a familiar palette that gives the nod to Michael Jordan’s UNC alma mater. The all-leather upper features a white base with powder blue overlays and a black signature Swoosh. Matching black accents make their way to the collar, tongue tag and printed Wings logo on the lateral collar flap. A brighter shade of blue is applied to the standard AJ1 outsole, featuring multi-directional traction and a pivot point under the forefoot.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 1 Retro High OG 'University Blue'", new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 7, "Air Jordan", "LifeStyle", "Yellow", "air-jordan-4-retro-lightning-2021-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(973), "The 2021 edition of the Air Jordan 4 Retro ‘Lightning’ resurrects a highly coveted colorway that originally launched in 2006 alongside an accompanying ‘Thunder’ colorway, both of which were inspired by Michael Jordan’s Motorsports team. A bright yellow hue floods the nubuck upper, contrasted by black netting and dark grey structural wings. Matching grey accents land on the woven tongue tag, interior tongue and Jumpman branding at the heel. A white PU midsole, enhanced with visible Air sole cushioning, rides on a dark grey herringbone rubber outsole.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 4 Retro 'Lightning' 2021'", new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 8, "Air Jordan", "LifeStyle", "Red", "air-jordan-5-retro-gs-raging-bull-2021-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1060), "The 2021 reissue of the Air Jordan 5 Retro ‘Raging Bull’ brings back a beloved colorway originally released as one-half of 2009’s Air Jordan 5 Raging Bulls Pack. The shoe’s defining feature is a plush Varsity Red suede upper, equipped with black eyelets and a Jumpman-branded reflective silver tongue. The heel overlay displays a second Jumpman logo and an embroidered 23 on the lateral side. A visible Nike Air heel unit enhances the polyurethane midsole, accented with red-tipped shark tooth detailing and supported by an icy translucent outsole.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 5 Retro 'Raging Bull' 2021'", new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 9, "Air Jordan", "LifeStyle", "Red", "air-jordan-11-retro-bred-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1107), "The Air Jordan 11 Retro 'Bred' 2019 brings back an original colorway initially debuted in 1995. The Tinker Hatfield-designed silhouette features Chicago Bulls colors, with black mesh on the upper sitting atop shiny black patent leather. A white midsole melds nicely with a translucent Varsity Red outsole, and is the same colorway that Michael Jordan wore during the 1996 NBA championship playoff run. This retro was distributed in December 2019 with OG detailing, including high-cut patent leather, signature Jumpman branding and MJ's number 23 stamped on the heel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 11 Retro 'Bred' 2019", new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 10, "Air Jordan", "LifeStyle", "Green", "air-jordan-1-retro-high-og-ps-seafoam-1", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1154), "Crafted for little kids, the Air Jordan 1 Retro High OG PS ‘Seafoam’ updates the iconic silhouette with a two-tone palette geared for the warm weather months. The upper is constructed from clean white leather with contrasting nubuck overlays in a pale green finish. The same pastel hue is repeated on the signature Swoosh, Nike branded tongue tag and durable rubber outsole. Woven white laces are outlined in reddish bronze for an unexpected pop of contrasting color.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " ", new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Youth", null },
                    { 11, "Air Jordan", "LifeStyle", "Blue", "air-jordan-1-retro-high-og-dark-marina-blue-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1223), "The Air Jordan 1 Retro High OG ‘Dark Marina Blue’ dresses the iconic silhouette in classic two-tone color blocking. The all-leather upper features a black base with contrasting dark blue overlays along the forefoot, heel, collar and eyestay. A matching blue Swoosh is accompanied by a Jordan Wings logo stamped in black on the lateral collar flap. Atop the nylon tongue, a woven Nike Air tag nods to the shoe’s retro cushioning technology: an Air-sole unit encapsulated in polyurethane nestled in the heel of the rubber cupsole.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Jordan 1 Retro High OG 'Dark Marina Blue'", new DateTime(2022, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 12, "Air Jordan", "LifeStyle", "Tan", "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1276), "The stash pouch makes a repeat appearance on the lateral collar, while new zippered detailing is added to the medial side. Mismatched Nike Air and Cactus Jack branding adorns the heel of the left and right shoe, with additional graphics on the midsole, outsole, tongue and lace lock.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis Scott x Air Jordan 6 Retro 'British Khaki'", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 13, "Adidas", "Running", "Black", "Ultra-4D-OG-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1323), "The adidas Ultra 4D ‘OG’ borrows a familiar color scheme initially featured on the UltraBoost release from 2015. This pair replaces the signature Boost cushioning of the original with a futuristic adidas 4D midsole, using a lattice structure made with a blend of liquid resin, light and oxygen. Up top, a matching black knit build is reinforced with a tonal midfoot cage and contrasting purple heel counter marked with Ultra 4D branding.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'OG'", new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 14, "Adidas", "Running", "Black", "ultra-4d-5-0-carbon-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1390), "The adidas Ultra 4D 5.0 ‘Carbon’ delivers a monotone take on a performance runner built on the brand’s revolutionary 3D-printed midsole, featuring a unique lattice structure crafted from a blend of light, oxygen and liquid resin. Up top, breathable Primeknit weaves together black and grey fibers to create unique patterns around the toe box and collar. Three-stripe branding is integrated into the midfoot cage, which works in tandem with a molded heel counter to provide added stability and support.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 5.0 'Carbon'", new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 15, "Adidas", "Running", "Grey", "ultra-4d-grey-pink-gradient-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1437), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'Grey Pink Gradient'", new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 16, "Adidas", "Running", "White", "Ultra-4D-Chalk-White-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1517), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'Chalk White'", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 17, "Adidas", "Running", "Cream", "ultra-4d-lemon-twist.png", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1569), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ultra 4D 'Lemon Twist'", new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 18, "Nike", "Basketball", "Cream", "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1617), "Designed in partnership with the influential Tokyo-based retailer, the atmos x Nike LeBron 18 Low ‘Cherry Blossom’ showcases a spring-ready design, highlighted by a Swoosh formed with pink embroidered florals. The pastel hue is repeated on the sneaker’s molded eyelets and TPU heel counter, as well as a multicolor geometric print that enlivens the textile upper. The low-top sits on a cushy React foam midsole with a large-volume Max Air unit nestled under the heel.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "atmos x LeBron 18 Low 'Sakura'", new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 19, "Nike", "Basketball", "Orange", "Little-Posite-One-GS-Twilight-Pulse-1.png", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1693), "The Nike Little Posite One GS ‘Twilight Pulse’ dresses Penny Hardaway’s signature shoe with a matte black finish on the molded synthetic upper. Metallic blue accents deliver contrasting color on the eyestay and collar trim, as does the bright orange shank plate integrated into the translucent sole unit. A mesh tongue and heel inlay provide breathable comfort while the attached pull loops are included for easy on and off.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little Posite One GS 'Twilight Pulse'", new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Youth", null },
                    { 20, "Nike", "Basketball", "Blue", "little-posite-one-xx-royal-1.png", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1741), "Nike released a grade school exclusive to celebrate the 20th-anniversary of the Nike Air Foamposite One. The Little Posite One XX GS 'Royal' features a shiny Royal Blue Foamposite shell with black suede details on the eyestay and collar. The sneaker also boasts a carbon fiber midfoot arch, a mini white Swoosh on the forefoot, an icy blue translucent outsole, and a mesh inner sleeve for breathability and comfort.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Little Posite One XX GS 'Royal'", new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Youth", null },
                    { 21, "Nike", "Basketball", "White", "kyrie-5-ep-have-a-nike-day-1.png", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1789), "A special edition of Kyrie Irving’s fifth model in his signature line, the Nike Kyrie 5 basketball shoe was one of the sneakers selected to be part of Nike’s celebratory 'Have A Nike Day' collection. Released in June 2019, the shoe is comprised of an engineered mesh upper for breathable, natural movement. The exterior is fitted with denim overlays, multicolored accents and Nike’s retro smiley face logo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyrie 5 'Have A Nike Day'", new DateTime(2019, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 22, "Nike", "Basketball", "White", "zoom-kd-12-wolf-grey-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1834), "Doused in a 'Wolf Grey' colorway, the July 2019 Nike's Zoom KD 12 features a breathable and lightweight mesh upper with Flywire for lock-down, emulating the 'worn-in' feel NBA star Kevin Durant prefers. The shoe eliminates the more-typical strobel layer between the upper by stitching an iridescent, full-length Zoom Air unit directly to the upper increasing energy-return and spring on the court.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zoom KD 12 'Wolf Grey'", new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneaker", "Men", null },
                    { 23, "Supreme", "Outerwear", "Red", "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(1880), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x The North Face Faux Fur Nuptse Jacket 'Red'", new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 24, "Supreme", "Outerwear", "Red", "supreme-x-nike-half-zip-hooded-sweatshirt-white-2.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2072), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x Nike Half Zip Hooded Sweatshirt 'White'", new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 25, "Supreme", "Outerwear", "Multi-Color", "supreme-saint-michael-fleece-jacket-white-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2123), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme Saint Michael Fleece Jacket 'White'", new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 26, "Supreme", "Outerwear", "Gold", "supreme-x-the-north-face-cargo-jacket-gold.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2169), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x The North Face Cargo Jacket 'Gold'", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 27, "Supreme", "Outerwear", "Black", "supreme-x-the-north-face-s-logo-mountain-jacket-black-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2214), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supreme x The North Face S Logo Mountain Jacket 'Black'", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Men", null },
                    { 28, "Fear of God Essentials", "Tops", "Black", "fear-of-god-essentials-kids-short-sleeve-polo-stretch-limo.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2259), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids Short-Sleeve Polo 'Stretch Limo'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 29, "Fear of God Essentials", "Outerwear", "Black", "fear-of-god-essentials-kids-pullover-hoodie-stretch-limo.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2328), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids Pullover Hoodie 'Stretch Limo'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 30, "Fear of God Essentials", "Bottoms", "Black", "fear-of-god-essentials-kids-sweatpant-stretch-limo.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2375), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids Sweatpant 'Stretch Limo'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 31, "Fear of God Essentials", "Accessories", "Brown", "fear-of-god-essentials-rc-9fifty-cap-black-1.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2441), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials RC 9FIFTY Cap 'Black'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null },
                    { 32, "Supreme", "Outerwear", "Fear of God Essentials", "fear-of-god-essentials-x-mr-porter-exclusive-hoodie-vicunia.jpeg", new DateTime(2022, 3, 2, 22, 52, 4, 285, DateTimeKind.Local).AddTicks(2553), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fear of God Essentials Kids x Mr. Porter Exclusive Hoodie 'Vicunia'", new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel", "Youth", null }
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
                values: new object[] { "fear-of-god-essentials-rc-9fifty-cap-black-1.jpeg", 31 });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[] { "fear-of-god-essentials-rc-9fifty-cap-black-2.jpeg", 31 });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Image", "ProductId" },
                values: new object[] { "fear-of-god-essentials-x-mr-porter-exclusive-hoodie-vicunia.jpeg", 32 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole<Guid>");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-boost-700-mauve-1.jpeg", 1 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-boost-700-mauve-2.jpeg", 1 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-boost-700-mauve-3.jpeg", 1 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-boost-700-mauve-4.jpeg", 1 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-boost-700-mauve-5.jpeg", 1 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-boost-700-mauve-6.jpeg", 1 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-boost-700-mauve-7.jpeg", 1 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-boost-700-mauve-8.jpeg", 1 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-1.jpeg", 2 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-10.jpeg", 2 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-2.jpeg", 2 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-3.jpeg", 2 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-4.jpeg", 2 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-5.jpeg", 2 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-6.jpeg", 2 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-7.jpeg", 2 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-8.jpeg", 2 });

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumns: new[] { "Image", "ProductId" },
                keyValues: new object[] { "yeezy-knit-runner-sulfur-9.jpeg", 2 });

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("096149b4-92aa-4d5f-89ab-579244023ae6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("218a643e-c736-4680-b8fc-6464f3e4b963"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3ebc9915-5931-471b-8cdb-a1b5b10b6088"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b9685628-aa98-4a0f-9a97-f872a932f211"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f408ea82-601a-4573-9a68-c0e31fd87623"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fa12454e-ebc4-4eb8-9290-93dddcc94bde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.DeleteData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Adidas");

            migrationBuilder.DeleteData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Air Jordan");

            migrationBuilder.DeleteData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Fear of God Essentials");

            migrationBuilder.DeleteData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Nike");

            migrationBuilder.DeleteData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Supreme");

            migrationBuilder.DeleteData(
                table: "BrandSilhouttes",
                keyColumn: "NameId",
                keyValue: "Yeezy");
        }
    }
}
