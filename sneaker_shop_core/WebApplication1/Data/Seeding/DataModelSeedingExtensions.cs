using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;
using WebApplication1.Infrastructure.Enums;
using WebApplication1.Infrastructure.Extensions;

namespace WebApplication1.Data.Seeding
{
    public static class DataModelSeedingExtensions
    {
        //private const string datetimeFormat = "dd-mm-yyyy";
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region brandsilhoutte
            var adidas = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                Icon = "adidas.png",
                NameId = "Adidas",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Brand),
                Story = "Adi Dassler founded adidas in 1949 in Herzogenaurach, Germany. Building on the reputation of the brand’s spiked running shoes and football cleats, Dassler turned adidas into a global icon, redefining sneakers and apparel in the process. Today, adidas is considered one of the world’s most influential brands, responsible for the Stan Smith, Yeezy sneakers and more."
            };
            var nike = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Nike",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Brand),
                Icon = "nike.png",
                Story = "Founded by Bill Bowerman and Phil Knight in 1964, Nike is synonymous with performance and innovation. Alongside its apparel offerings, the sportswear giant is responsible for a number of iconic sneakers, including the Air Force 1, the Air Max franchise and more. Today, Nike is among the world’s most recognized brands, identified by its wordmark and Swoosh logo."
            };
            var jordan = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Air Jordan",
                Icon = "jordan.png",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Brand),
                Story = "In 1984, Nike unveiled the Air Jordan 1, a basketball sneaker designed by Peter Moore for a young Michael Jordan. The iconic silhouette transcended sneakers and sports, altering the trajectory of style forever. Today, Michael Jordan’s namesake brand continues to inspire sportswear and style movements around the world through new releases, retro drops and unexpected collaborations."
            };
            var supreme = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Supreme",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Brand),
                Story = "Founded by James Jebbia in 1994, Supreme is a New York-based skate brand known for its subcultural references and controversial graphics. Today, Supreme is considered one of style’s most influential voices, blurring the lines between streetwear and luxury through collaborations with artists, fashion houses and sneaker brands."
            };
            var yezzy = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Yeezy",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Brand),
                Story = "In late 2013, Kanye West and adidas announced their forthcoming partnership. In 2015, the two delivered on this news, arriving in the form of Yeezy Season 1, a collection of sneakers and apparel debuted at New York Fashion Week. Since the first collection, Yeezy has influenced style movements worldwide."
            };
            var fog = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Fear of God Essentials",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Brand),
                Story = "In 2018, Jerry Lorenzo launched Fear of God Essentials, a pared-back version of Fear of God. Each seasonal collection brings the line’s concept into sharper focus, uniting elevated sportswear basics with subdued shades and minimal branding."
            };
            var yezzy700 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Yeezy 700",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var yezzyKnit = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Yeezy Knit Runner",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var yezzyFoam = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Yeezy Foam Runner",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var yezzy450 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Yeezy 450",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var yezzy350 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Yeezy 350",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var jordan1 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Air Jordan 1",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var jordan4 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Air Jordan 4",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var jordan5 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Air Jordan 5",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var jordan6 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Air Jordan 6",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var jordan11 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Air Jordan 11",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var ultra4d = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Ultra 4D",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var leborn18 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "LeBron 18",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var littleOne = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Little Posite One",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var kyrie5 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Kyrie 5",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            var kd12 = new BrandSilhouette()
            {
                CreatedAt = DateTime.Now,
                NameId = "Zoom KD 12",
                Type = EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette),
            };
            modelBuilder.Entity<BrandSilhouette>().HasData(
               adidas,
               nike,
               supreme,
               ultra4d,
               jordan,
               yezzy,
               fog,
               yezzy350,
               yezzy450,
               yezzy700,
               yezzyFoam,
               yezzyKnit,
               jordan1,
               jordan11,
               jordan4,
               jordan5,
               jordan6,
               littleOne,
               leborn18,
               kd12,
               kyrie5

            );
            #endregion
            #region product
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Name = "Yeezy Boost 700 V2 'Mauve'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-26-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Boots),
                    Color = "Tan",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "yeezy-boost-700-mauve-1.jpeg",
                    Description = "The adidas Yeezy Boost 700 V2 ‘Mauve’ brings back a popular colorway first seen on a Yeezy Boost 700 release from 2018. The sneaker’s titular hue is executed on a textured mesh upper with arcing no-sew skins along the quarter panel and greenish-grey suede overlays throughout. Responsive cushioning comes courtesy of a full-length drop-in Boost midsole, housed within a sculpted polyurethane carrier. Underfoot, a herringbone-traction rubber outsole provides optimal grip.",
                    Id = 1,
                },
                new Product()
                {
                    Name = "Yeezy Knit Runner 'Sulfur'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-24-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Sulfur",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "yeezy-knit-runner-sulfur-1.jpeg",
                    Description = "The adidas Yeezy Knit Runner ‘Sulfur’ delivers the debut colorway of Kanye West’s sock-like silhouette, which launched exclusively through the artist’s Yeezy Supply site. The fully knit build, rendered in a neutral tan shade with a contrasting mustard yellow finish throughout the majority of the upper, utilizes slip-on construction devoid of exterior branding. Embellishments are limited to sizing information stamped on the lateral collar. The sneaker rides on a durable rubber outsole in a matching yellow finish, featuring a modified herringbone tread and adidas branding under the heel.",
                    Id = 2,
                },
                new Product()
                {
                    Name = "Yeezy Foam Runner 'Ochre'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-19-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Yellow",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "yeezy-foam-runner-ochre-1.jpg",
                    Description = "The adidas Yeezy Foam Runner ‘Ochre’ complements its futuristic aesthetic with a subdued, monochromatic finish. A dark beige hue suffuses the one-piece foam build, featuring ventilation ports of varying shapes and dimensions that enhance breathability while adding depth to the slip-on’s flowing lines. ‘FOAM RNNR’ is debossed on the interior collar, alongside the shoe size and ‘Made in USA’ branding. Underfoot, the outsole features a wavy traction pattern for reliable grip.",
                    Id = 3,
                },
                new Product()
                {
                    Name = "Yeezy 450 'Dark Slate'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("06-27-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "yeezy-450-dark-slate-1.jpeg",
                    Description = "The adidas Yeezy 450 ‘Dark Slate’ delivers a blacked-out iteration of Kanye West’s boundary-pushing silhouette. Stripped of color and exterior branding, the knit upper is secured with an integrated lacing system and topped with an elastic, sock-like cuff. In lieu of a traditional midsole, the rubber outsole sprouts tapered appendages that wrap up the heel and side panels of the deconstructed build, providing support and enhanced durability within its grasp.",
                    Id = 4,
                },
                new Product()
                {
                    Name = "Yeezy Boost 350 V2 'Mono Cinder'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("06-25-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "Yeezy-Boost-350-V2-Mono-Cinder-1.jpeg",
                    Description = "Launching as part of a four-piece ‘Mono’ pack, the adidas Yeezy Boost 350 V2 ‘Mono Cinder’ applies a black-out finish to the lifestyle sneaker. The revised design features an upper crafted from monofilament mesh, reinforced with an interior cage and accented with a tonal lateral side stripe. A webbing pull tab at the heel allows the sock-like build to be easily slipped on and off. The stealthy palette extends to the midsole, featuring wrapped Boost cushioning that runs the length of the rubber outsole. This shoe released exclusively on Yeezy Supply.",
                    Id = 5,
                },
                new Product()
                {
                    Name = "Air Jordan 1 Retro High OG 'University Blue'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("03-07-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Blue",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "air-jordan-1-retro-high-og-university-blue-1.jpeg",
                    Description = "The Air Jordan 1 Retro High OG ‘University Blue’ makes use of a familiar palette that gives the nod to Michael Jordan’s UNC alma mater. The all-leather upper features a white base with powder blue overlays and a black signature Swoosh. Matching black accents make their way to the collar, tongue tag and printed Wings logo on the lateral collar flap. A brighter shade of blue is applied to the standard AJ1 outsole, featuring multi-directional traction and a pivot point under the forefoot.",
                    Id = 6,
                },
                new Product()
                {
                    Name = "Air Jordan 4 Retro 'Lightning' 2021'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("08-29-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Yellow",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "air-jordan-4-retro-lightning-2021-1.jpeg",
                    Description = "The 2021 edition of the Air Jordan 4 Retro ‘Lightning’ resurrects a highly coveted colorway that originally launched in 2006 alongside an accompanying ‘Thunder’ colorway, both of which were inspired by Michael Jordan’s Motorsports team. A bright yellow hue floods the nubuck upper, contrasted by black netting and dark grey structural wings. Matching grey accents land on the woven tongue tag, interior tongue and Jumpman branding at the heel. A white PU midsole, enhanced with visible Air sole cushioning, rides on a dark grey herringbone rubber outsole.",
                    Id = 7,
                },
                new Product()
                {
                    Name = "Air Jordan 5 Retro 'Raging Bull' 2021'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("04-11-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Red",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "air-jordan-5-retro-gs-raging-bull-2021-1.jpeg",
                    Description = "The 2021 reissue of the Air Jordan 5 Retro ‘Raging Bull’ brings back a beloved colorway originally released as one-half of 2009’s Air Jordan 5 Raging Bulls Pack. The shoe’s defining feature is a plush Varsity Red suede upper, equipped with black eyelets and a Jumpman-branded reflective silver tongue. The heel overlay displays a second Jumpman logo and an embroidered 23 on the lateral side. A visible Nike Air heel unit enhances the polyurethane midsole, accented with red-tipped shark tooth detailing and supported by an icy translucent outsole.",
                    Id = 8,
                },
                new Product()
                {
                    Name = "Air Jordan 11 Retro 'Bred' 2019",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("12-15-2019"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Red",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "air-jordan-11-retro-bred-1.jpeg",
                    Description = "The Air Jordan 11 Retro 'Bred' 2019 brings back an original colorway initially debuted in 1995. The Tinker Hatfield-designed silhouette features Chicago Bulls colors, with black mesh on the upper sitting atop shiny black patent leather. A white midsole melds nicely with a translucent Varsity Red outsole, and is the same colorway that Michael Jordan wore during the 1996 NBA championship playoff run. This retro was distributed in December 2019 with OG detailing, including high-cut patent leather, signature Jumpman branding and MJ's number 23 stamped on the heel.",
                    Id = 9,
                },
                new Product()
                {
                    Name = "Air Jordan 1 Retro High OG PS 'Seafoam'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("08-13-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Green",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "air-jordan-1-retro-high-og-ps-seafoam-1.jpeg",
                    Description = "Crafted for little kids, the Air Jordan 1 Retro High OG PS ‘Seafoam’ updates the iconic silhouette with a two-tone palette geared for the warm weather months. The upper is constructed from clean white leather with contrasting nubuck overlays in a pale green finish. The same pastel hue is repeated on the signature Swoosh, Nike branded tongue tag and durable rubber outsole. Woven white laces are outlined in reddish bronze for an unexpected pop of contrasting color.",
                    Id = 10,
                },
                new Product()
                {
                    Name = "Air Jordan 1 Retro High OG 'Dark Marina Blue'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("02-17-2022"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Blue",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "air-jordan-1-retro-high-og-dark-marina-blue-1.jpeg",
                    Description = "The Air Jordan 1 Retro High OG ‘Dark Marina Blue’ dresses the iconic silhouette in classic two-tone color blocking. The all-leather upper features a black base with contrasting dark blue overlays along the forefoot, heel, collar and eyestay. A matching blue Swoosh is accompanied by a Jordan Wings logo stamped in black on the lateral collar flap. Atop the nylon tongue, a woven Nike Air tag nods to the shoe’s retro cushioning technology: an Air-sole unit encapsulated in polyurethane nestled in the heel of the rubber cupsole.",
                    Id = 11,
                },
                new Product()
                {
                    Name = "Travis Scott x Air Jordan 6 Retro 'British Khaki'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("05-01-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Tan",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-1.jpeg",
                    Description = "The stash pouch makes a repeat appearance on the lateral collar, while new zippered detailing is added to the medial side. Mismatched Nike Air and Cactus Jack branding adorns the heel of the left and right shoe, with additional graphics on the midsole, outsole, tongue and lace lock.",
                    Id = 12,

                },
                new Product()
                {
                    Name = "Ultra 4D 'OG'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("08-14-2020"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "Ultra-4D-OG-1.jpeg",
                    Description = "The adidas Ultra 4D ‘OG’ borrows a familiar color scheme initially featured on the UltraBoost release from 2015. This pair replaces the signature Boost cushioning of the original with a futuristic adidas 4D midsole, using a lattice structure made with a blend of liquid resin, light and oxygen. Up top, a matching black knit build is reinforced with a tonal midfoot cage and contrasting purple heel counter marked with Ultra 4D branding.",
                    Id = 13,
                },
                new Product()
                {
                    Name = "Ultra 4D 5.0 'Carbon'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("12-13-2020"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "ultra-4d-5-0-carbon-1.jpeg",
                    Description = "The adidas Ultra 4D 5.0 ‘Carbon’ delivers a monotone take on a performance runner built on the brand’s revolutionary 3D-printed midsole, featuring a unique lattice structure crafted from a blend of light, oxygen and liquid resin. Up top, breathable Primeknit weaves together black and grey fibers to create unique patterns around the toe box and collar. Three-stripe branding is integrated into the midfoot cage, which works in tandem with a molded heel counter to provide added stability and support.",
                    Id = 14,
                },
                new Product()
                {
                    Name = "Ultra 4D 'Grey Pink Gradient'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("02-27-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "Grey",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "ultra-4d-grey-pink-gradient-1.jpeg",
                    Description = "",
                    Id = 15,
                },
                new Product()
                {
                    Name = "Ultra 4D 'Chalk White'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("12-15-2020"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "White",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "Ultra-4D-Chalk-White-1.jpeg",
                    Description = "",
                    Id = 16,
                },
                new Product()
                {
                    Name = "Ultra 4D 'Lemon Twist'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("12-04-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "Cream",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "ultra-4d-lemon-twist.png",
                    Description = "",
                    Id = 17,
                },
                new Product()
                {
                    Name = "atmos x LeBron 18 Low 'Sakura'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("04-24-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "Cream",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg",
                    Description = "Designed in partnership with the influential Tokyo-based retailer, the atmos x Nike LeBron 18 Low ‘Cherry Blossom’ showcases a spring-ready design, highlighted by a Swoosh formed with pink embroidered florals. The pastel hue is repeated on the sneaker’s molded eyelets and TPU heel counter, as well as a multicolor geometric print that enlivens the textile upper. The low-top sits on a cushy React foam midsole with a large-volume Max Air unit nestled under the heel.",
                    Id = 18,
                },
                new Product()
                {
                    Name = "Little Posite One GS 'Twilight Pulse'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-02-2018"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "Orange",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "Little-Posite-One-GS-Twilight-Pulse-1.png",
                    Description = "The Nike Little Posite One GS ‘Twilight Pulse’ dresses Penny Hardaway’s signature shoe with a matte black finish on the molded synthetic upper. Metallic blue accents deliver contrasting color on the eyestay and collar trim, as does the bright orange shank plate integrated into the translucent sole unit. A mesh tongue and heel inlay provide breathable comfort while the attached pull loops are included for easy on and off.",
                    Id = 19,
                },
                new Product()
                {
                    Name = "Little Posite One XX GS 'Royal'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-02-2018"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "Blue",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "little-posite-one-xx-royal-1.png",
                    Description = "Nike released a grade school exclusive to celebrate the 20th-anniversary of the Nike Air Foamposite One. The Little Posite One XX GS 'Royal' features a shiny Royal Blue Foamposite shell with black suede details on the eyestay and collar. The sneaker also boasts a carbon fiber midfoot arch, a mini white Swoosh on the forefoot, an icy blue translucent outsole, and a mesh inner sleeve for breathability and comfort.",
                    Id = 20,
                },
                new Product()
                {
                    Name = "Kyrie 5 'Have A Nike Day'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("06-09-2019"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "White",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "kyrie-5-ep-have-a-nike-day-1.png",
                    Description = "A special edition of Kyrie Irving’s fifth model in his signature line, the Nike Kyrie 5 basketball shoe was one of the sneakers selected to be part of Nike’s celebratory 'Have A Nike Day' collection. Released in June 2019, the shoe is comprised of an engineered mesh upper for breathable, natural movement. The exterior is fitted with denim overlays, multicolored accents and Nike’s retro smiley face logo.",
                    Id = 21,
                },
                new Product()
                {
                    Name = "Zoom KD 12 'Wolf Grey'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("06-08-2019"),
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "White",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "zoom-kd-12-wolf-grey-1.jpeg",
                    Description = "Doused in a 'Wolf Grey' colorway, the July 2019 Nike's Zoom KD 12 features a breathable and lightweight mesh upper with Flywire for lock-down, emulating the 'worn-in' feel NBA star Kevin Durant prefers. The shoe eliminates the more-typical strobel layer between the upper by stitching an iridescent, full-length Zoom Air unit directly to the upper increasing energy-return and spring on the court.",
                    Id = 22,
                },
                new Product()
                {
                    Name = "Supreme x The North Face Faux Fur Nuptse Jacket 'Red'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2020"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Red",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-1.jpeg",
                    Description = "",
                    Id = 23,
                },
                new Product()
                {
                    Name = "Supreme x Nike Half Zip Hooded Sweatshirt 'White'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("03-12-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Red",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "supreme-x-nike-half-zip-hooded-sweatshirt-white-2.jpeg",
                    Description = "",
                    Id = 24,
                },
                new Product()
                {
                    Name = "Supreme Saint Michael Fleece Jacket 'White'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("04-02-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Multi-Color",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "supreme-saint-michael-fleece-jacket-white-1.jpeg",
                    Description = "",
                    Id = 25,
                },
                new Product()
                {
                    Name = "Supreme x The North Face Cargo Jacket 'Gold'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-01-2020"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Gold",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "supreme-x-the-north-face-cargo-jacket-gold.jpeg",
                    Description = "",
                    Id = 26,
                },
                new Product()
                {
                    Name = "Supreme x The North Face S Logo Mountain Jacket 'Black'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-01-2020"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "supreme-x-the-north-face-s-logo-mountain-jacket-black-1.jpeg",
                    Description = "",
                    Id = 27,
                },
                new Product()
                {
                    Name = "Fear of God Essentials Kids Short-Sleeve Polo 'Stretch Limo'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Tops),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "fear-of-god-essentials-kids-short-sleeve-polo-stretch-limo.jpeg",
                    Description = "",
                    Id = 28,
                },
                new Product()
                {
                    Name = "Fear of God Essentials Kids Pullover Hoodie 'Stretch Limo'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "fear-of-god-essentials-kids-pullover-hoodie-stretch-limo.jpeg",
                    Description = "",
                    Id = 29,
                },
                new Product()
                {
                    Name = "Fear of God Essentials Kids Sweatpant 'Stretch Limo'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Bottoms),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "fear-of-god-essentials-kids-sweatpant-stretch-limo.jpeg",
                    Description = "",
                    Id = 30,
                },
                new Product()
                {
                    Name = "Fear of God Essentials RC 9FIFTY Cap 'Black'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Accessories),
                    Color = "Brown",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "fear-of-god-essentials-rc-9fifty-cap-black-1.jpeg",
                    Description = "",
                    Id = 31,
                },
                new Product()
                {
                    Name = "Fear of God Essentials Kids x Mr. Porter Exclusive Hoodie 'Vicunia'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Fear of God Essentials",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "fear-of-god-essentials-x-mr-porter-exclusive-hoodie-vicunia.jpeg",
                    Description = "",
                    Id = 32,
                }
            );
            #endregion
            #region product-brandsilhouette
            modelBuilder.Entity<Product>()
                .HasMany(x => x.BrandSilhouette)
                .WithMany(x => x.Products)
                .UsingEntity(x => x.ToTable("BrandSilhouetteProduct")
                .HasData(
                    new[]
                    {
                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 1},
                        new {BrandSilhouetteNameId = yezzy.NameId, ProductsId = 1},
                        new {BrandSilhouetteNameId = yezzy700.NameId, ProductsId = 1},

                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 2},
                        new {BrandSilhouetteNameId = yezzy.NameId, ProductsId = 2},
                        new {BrandSilhouetteNameId = yezzyKnit.NameId, ProductsId = 2},

                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 3},
                        new {BrandSilhouetteNameId = yezzy.NameId, ProductsId = 3},
                        new {BrandSilhouetteNameId = yezzyFoam.NameId, ProductsId = 3},

                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 4},
                        new {BrandSilhouetteNameId = yezzy.NameId, ProductsId = 4},
                        new {BrandSilhouetteNameId = yezzy450.NameId, ProductsId = 4},

                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 5},
                        new {BrandSilhouetteNameId = yezzy.NameId, ProductsId = 5},
                        new {BrandSilhouetteNameId = yezzy350.NameId, ProductsId = 5},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 6},
                        new {BrandSilhouetteNameId = jordan.NameId, ProductsId = 6},
                        new {BrandSilhouetteNameId = jordan1.NameId, ProductsId = 6},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 7},
                        new {BrandSilhouetteNameId = jordan.NameId, ProductsId = 7},
                        new {BrandSilhouetteNameId = jordan4.NameId, ProductsId = 7},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 8},
                        new {BrandSilhouetteNameId = jordan.NameId, ProductsId = 8},
                        new {BrandSilhouetteNameId = jordan5.NameId, ProductsId = 8},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 9},
                        new {BrandSilhouetteNameId = jordan.NameId, ProductsId = 9},
                        new {BrandSilhouetteNameId = jordan11.NameId, ProductsId = 9},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 10},
                        new {BrandSilhouetteNameId = jordan.NameId, ProductsId = 10},
                        new {BrandSilhouetteNameId = jordan1.NameId, ProductsId = 10},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 11},
                        new {BrandSilhouetteNameId = jordan.NameId, ProductsId = 11},
                        new {BrandSilhouetteNameId = jordan1.NameId, ProductsId = 11},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 12},
                        new {BrandSilhouetteNameId = jordan.NameId, ProductsId = 12},
                        new {BrandSilhouetteNameId = jordan6.NameId, ProductsId = 12},

                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 13},
                        new {BrandSilhouetteNameId = ultra4d.NameId, ProductsId = 13},

                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 14},
                        new {BrandSilhouetteNameId = ultra4d.NameId, ProductsId = 14},

                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 15},
                        new {BrandSilhouetteNameId = ultra4d.NameId, ProductsId = 15},

                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 16},
                        new {BrandSilhouetteNameId = ultra4d.NameId, ProductsId = 16},

                        new {BrandSilhouetteNameId = adidas.NameId, ProductsId = 17},
                        new {BrandSilhouetteNameId = ultra4d.NameId, ProductsId = 17},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 18},
                        new {BrandSilhouetteNameId = leborn18.NameId, ProductsId = 18},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 19},
                        new {BrandSilhouetteNameId = littleOne.NameId, ProductsId = 19},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 20},
                        new {BrandSilhouetteNameId = littleOne.NameId, ProductsId = 20},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 21},
                        new {BrandSilhouetteNameId = kyrie5.NameId, ProductsId = 21},

                        new {BrandSilhouetteNameId = nike.NameId, ProductsId = 22},
                        new {BrandSilhouetteNameId = kd12.NameId, ProductsId = 22},

                        new {BrandSilhouetteNameId = supreme.NameId, ProductsId = 23},
                        new {BrandSilhouetteNameId = supreme.NameId, ProductsId = 24},
                        new {BrandSilhouetteNameId = supreme.NameId, ProductsId = 25},
                        new {BrandSilhouetteNameId = supreme.NameId, ProductsId = 26},
                        new {BrandSilhouetteNameId = supreme.NameId, ProductsId = 27},

                        new {BrandSilhouetteNameId = fog.NameId, ProductsId = 28},
                        new {BrandSilhouetteNameId = fog.NameId, ProductsId = 29},
                        new {BrandSilhouetteNameId = fog.NameId, ProductsId = 30},
                        new {BrandSilhouetteNameId = fog.NameId, ProductsId = 31},
                        new {BrandSilhouetteNameId = fog.NameId, ProductsId = 32},
                    }
            ));
            #endregion
            #region product inventory
            modelBuilder.Entity<ProductInventory>().HasData(
                new ProductInventory()
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                    ProductId = 1,
                },
                new ProductInventory()
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                    ProductId = 1,
                },
                new ProductInventory()
                {
                    Id = 3,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                    ProductId = 1,
                },
                new ProductInventory()
                {
                    Id = 4,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                    ProductId = 2,
                },
                new ProductInventory()
                {
                    Id = 5,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                    ProductId = 2,
                },
                new ProductInventory()
                {
                    Id = 6,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                    ProductId = 2,
                },
                new ProductInventory()
                {
                    Id = 7,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                    ProductId = 3,
                },
                new ProductInventory()
                {
                    Id = 8,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                    ProductId = 3,
                },
                new ProductInventory()
                {
                    Id = 9,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                    ProductId = 3,
                },
                new ProductInventory()
                {
                    Id = 10,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                    ProductId = 4,
                },
                new ProductInventory()
                {
                    Id = 11,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                    ProductId = 4,
                },
                new ProductInventory()
                {
                    Id = 12,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                    ProductId = 4,
                },
                new ProductInventory()
                {
                    Id = 13,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                    ProductId = 5,
                },
                new ProductInventory()
                {
                    Id = 14,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                    ProductId = 5,
                },
                new ProductInventory()
                {
                    Id = 15,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                    ProductId = 5,
                },
                new ProductInventory()
                {
                    Id = 16,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                    ProductId = 6,
                },
                new ProductInventory()
                {
                    Id = 17,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                    ProductId = 6,
                },
                new ProductInventory()
                {
                    Id = 18,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                    ProductId = 6,
                },
                new ProductInventory()
                {
                    Id = 19,
                    ProductId = 7,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 20,
                    ProductId = 7,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 21,
                    ProductId = 7,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 22,
                    ProductId = 8,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 23,
                    ProductId = 8,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 24,
                    ProductId = 8,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 25,
                    ProductId = 9,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 26,
                    ProductId = 9,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 27,
                    ProductId = 9,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 28,
                    ProductId = 10,
                    CreatedAt = DateTime.Now,
                    Size = "10.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 29,
                    ProductId = 10,
                    CreatedAt = DateTime.Now,
                    Size = "11",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 30,
                    ProductId = 10,
                    CreatedAt = DateTime.Now,
                    Size = "11.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 31,
                    ProductId = 11,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 32,
                    ProductId = 11,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 33,
                    ProductId = 11,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 34,
                    ProductId = 12,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 35,
                    ProductId = 12,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 36,
                    ProductId = 12,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 100,
                },
                 new ProductInventory()
                 {
                     Id = 37,
                     ProductId = 13,
                     CreatedAt = DateTime.Now,
                     Size = "8",
                     Quantity = 100,
                 },
                new ProductInventory()
                {
                    Id = 38,
                    ProductId = 13,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 39,
                    ProductId = 13,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 110,
                },
                new ProductInventory()
                {
                    Id = 40,
                    ProductId = 14,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 41,
                    ProductId = 14,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 42,
                    ProductId = 14,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 110,
                },
                new ProductInventory()
                {
                    Id = 43,
                    ProductId = 15,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 44,
                    ProductId = 15,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 45,
                    ProductId = 15,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 110,
                },
                new ProductInventory()
                {
                    Id = 46,
                    ProductId = 16,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 47,
                    ProductId = 16,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 48,
                    ProductId = 16,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 110,
                },
                new ProductInventory()
                {
                    Id = 49,
                    ProductId = 17,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 50,
                    ProductId = 17,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 51,
                    ProductId = 17,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 110,
                },
                new ProductInventory()
                {
                    Id = 52,
                    ProductId = 18,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 53,
                    ProductId = 18,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 54,
                    ProductId = 18,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 110,
                },
                new ProductInventory()
                {
                    Id = 55,
                    ProductId = 19,
                    CreatedAt = DateTime.Now,
                    Size = "3",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 56,
                    ProductId = 19,
                    CreatedAt = DateTime.Now,
                    Size = "3.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 57,
                    ProductId = 19,
                    CreatedAt = DateTime.Now,
                    Size = "4",
                    Quantity = 110,
                },
                new ProductInventory()
                {
                    Id = 58,
                    ProductId = 20,
                    CreatedAt = DateTime.Now,
                    Size = "3",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 59,
                    ProductId = 20,
                    CreatedAt = DateTime.Now,
                    Size = "3.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 60,
                    ProductId = 20,
                    CreatedAt = DateTime.Now,
                    Size = "4",
                    Quantity = 110,
                },
                new ProductInventory()
                {
                    Id = 61,
                    ProductId = 21,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 62,
                    ProductId = 21,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 63,
                    ProductId = 21,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 110,
                },
               new ProductInventory()
               {
                   Id = 64,
                   ProductId = 22,
                   CreatedAt = DateTime.Now,
                   Size = "8",
                   Quantity = 100,
               },
                new ProductInventory()
                {
                    Id = 65,
                    ProductId = 22,
                    CreatedAt = DateTime.Now,
                    Size = "8.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 66,
                    ProductId = 22,
                    CreatedAt = DateTime.Now,
                    Size = "9",
                    Quantity = 155,
                },
                new ProductInventory()
                {
                    Id = 67,
                    ProductId = 23,
                    CreatedAt = DateTime.Now,
                    Size = "M",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 68,
                    ProductId = 23,
                    CreatedAt = DateTime.Now,
                    Size = "L",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 69,
                    ProductId = 23,
                    CreatedAt = DateTime.Now,
                    Size = "XL",
                    Quantity = 155,
                },
                new ProductInventory()
                {
                    Id = 70,
                    ProductId = 24,
                    CreatedAt = DateTime.Now,
                    Size = "M",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 71,
                    ProductId = 24,
                    CreatedAt = DateTime.Now,
                    Size = "L",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 72,
                    ProductId = 24,
                    CreatedAt = DateTime.Now,
                    Size = "XL",
                    Quantity = 155,
                },
               new ProductInventory()
               {
                   Id = 73,
                   ProductId = 25,
                   CreatedAt = DateTime.Now,
                   Size = "M",
                   Quantity = 100,
               },
                new ProductInventory()
                {
                    Id = 74,
                    ProductId = 25,
                    CreatedAt = DateTime.Now,
                    Size = "L",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 75,
                    ProductId = 25,
                    CreatedAt = DateTime.Now,
                    Size = "XL",
                    Quantity = 155,
                },
                new ProductInventory()
                {
                    Id = 76,
                    ProductId = 26,
                    CreatedAt = DateTime.Now,
                    Size = "M",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 77,
                    ProductId = 26,
                    CreatedAt = DateTime.Now,
                    Size = "L",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 78,
                    ProductId = 27,
                    CreatedAt = DateTime.Now,
                    Size = "M",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 79,
                    ProductId = 27,
                    CreatedAt = DateTime.Now,
                    Size = "L",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 80,
                    ProductId = 27,
                    CreatedAt = DateTime.Now,
                    Size = "XL",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 81,
                    ProductId = 28,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 82,
                    ProductId = 28,
                    CreatedAt = DateTime.Now,
                    Size = "10",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 83,
                    ProductId = 29,
                    CreatedAt = DateTime.Now,
                    Size = "2/3",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 84,
                    ProductId = 29,
                    CreatedAt = DateTime.Now,
                    Size = "4",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 85,
                    ProductId = 29,
                    CreatedAt = DateTime.Now,
                    Size = "4.5",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 86,
                    ProductId = 30,
                    CreatedAt = DateTime.Now,
                    Size = "2/3",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 87,
                    ProductId = 30,
                    CreatedAt = DateTime.Now,
                    Size = "4",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 88,
                    ProductId = 30,
                    CreatedAt = DateTime.Now,
                    Size = "6",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 89,
                    ProductId = 31,
                    CreatedAt = DateTime.Now,
                    Size = "One Size",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 90,
                    ProductId = 32,
                    CreatedAt = DateTime.Now,
                    Size = "4",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 91,
                    ProductId = 32,
                    CreatedAt = DateTime.Now,
                    Size = "6",
                    Quantity = 100,
                },
                new ProductInventory()
                {
                    Id = 92,
                    ProductId = 32,
                    CreatedAt = DateTime.Now,
                    Size = "8",
                    Quantity = 100,
                }
            );
            #endregion
            #region product price
            modelBuilder.Entity<ProductPrice>().HasData(
                new ProductPrice()
                {
                    Price = 350,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 1,
                },
                new ProductPrice()
                {
                    Price = 385,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 2,
                },
                new ProductPrice()
                {
                    Price = 326,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 3,
                },
                new ProductPrice()
                {
                    Price = 540,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 4,
                },
                new ProductPrice()
                {
                    Price = 675,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 5
                },
                new ProductPrice()
                {
                    Price = 568,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 6,
                },
                new ProductPrice()
                {
                    Price = 229,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 7,
                },
                new ProductPrice()
                {
                    Price = 221,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 8
                },
                new ProductPrice()
                {
                    Price = 223,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 9,
                },
                new ProductPrice()
                {
                    Price = 342,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 10,
                },
                new ProductPrice()
                {
                    Price = 311,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 11,
                },
                new ProductPrice()
                {
                    Price = 280,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 12,
                },
                new ProductPrice()
                {
                    Price = 319,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 13,
                },
                new ProductPrice()
                {
                    Price = 318,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 14,
                },
                new ProductPrice()
                {
                    Price = 318,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 15,
                },
                new ProductPrice()
                {
                    Price = 325,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 16,
                },
                new ProductPrice()
                {
                    Price = 331,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 17,
                },
                new ProductPrice()
                {
                    Price = 300,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 18,
                },
                new ProductPrice()
                {
                    Price = 222,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 19,
                },
                new ProductPrice()
                {
                    Price = 236,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 20,
                },
                new ProductPrice()
                {
                    Price = 240,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 21,
                },
                new ProductPrice()
                {
                    Price = 145,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 22,
                },
                new ProductPrice()
                {
                    Price = 166,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 23,
                },
                new ProductPrice()
                {
                    Price = 141,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 24,
                },
                new ProductPrice()
                {
                    Price = 110,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 25,
                },
                new ProductPrice()
                {
                    Price = 200,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 26,
                },
                new ProductPrice()
                {
                    Price = 200,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 27,
                },
                new ProductPrice()
                {
                    Price = 189,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 28,
                },
                new ProductPrice()
                {
                    Price = 110,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 29,
                },
                new ProductPrice()
                {
                    Price = 110,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 30,
                },
                new ProductPrice()
                {
                    Price = 209,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 31,
                },
                new ProductPrice()
                {
                    Price = 210,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 32,
                },
                new ProductPrice()
                {
                    Price = 210,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 33,
                },
                new ProductPrice()
                {
                    Price = 390,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 34,
                },
                new ProductPrice()
                {
                    Price = 466,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 35,
                },
                new ProductPrice()
                {
                    Price = 410,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 36,
                },
                new ProductPrice()
                {
                    Price = 146,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 37,
                },
                new ProductPrice()
                {
                    Price = 140,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 38,
                },
                new ProductPrice()
                {
                    Price = 410,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                    ProductInventoryId = 39,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 40,
                    Price = 209,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 41,
                    Price = 198,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 42,
                    Price = 226,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 43,
                    Price = 177,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 44,
                    Price = 140,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 45,
                    Price = 166,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },


                new ProductPrice()
                {
                    ProductInventoryId = 46,
                    Price = 150,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 47,
                    Price = 102,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 48,
                    Price = 229,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },


                new ProductPrice()
                {
                    ProductInventoryId = 49,
                    Price = 280,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 50,
                    Price = 280,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 51,
                    Price = 280,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },


                new ProductPrice()
                {
                    ProductInventoryId = 52,
                    Price = 237,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 53,
                    Price = 202,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 54,
                    Price = 185,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 55,
                    Price = 120,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 56,
                    Price = 75,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 57,
                    Price = 100,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 58,
                    Price = 259,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 59,
                    Price = 244,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 60,
                    Price = 250,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },


                new ProductPrice()
                {
                    ProductInventoryId = 61,
                    Price = 483,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 62,
                    Price = 415,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 63,
                    Price = 564,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 64,
                    Price = 200,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 65,
                    Price = 230,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 66,
                    Price = 155,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 67,
                    Price = 745,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 68,
                    Price = 740,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 69,
                    Price = 1718,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 70,
                    Price = 250,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 71,
                    Price = 200,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 72,
                    Price = 360,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 73,
                    Price = 235,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 74,
                    Price = 300,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 75,
                    Price = 384,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 76,
                    Price = 775,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 77,
                    Price = 2000,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 78,
                    Price = 780,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 79,
                    Price = 729,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 80,
                    Price = 895,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 81,
                    Price = 100,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 82,
                    Price = 100,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 83,
                    Price = 150,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 84,
                    Price = 159,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 85,
                    Price = 137,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 86,
                    Price = 150,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 87,
                    Price = 124,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 88,
                    Price = 120,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },
                new ProductPrice()
                {
                    ProductInventoryId = 89,
                    Price = 69,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 90,
                    Price = 203,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 91,
                    Price = 201,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                },

                new ProductPrice()
                {
                    ProductInventoryId = 92,
                    Price = 194,
                    CreatedAt = DateTime.Now,
                    EffectTime = DateTime.Now,
                }
            );
            #endregion
            #region product image
            modelBuilder.Entity<ProductImage>().HasData(
              new ProductImage()
              {
                  Image = "yeezy-boost-700-mauve-1.jpeg",
                  ProductId = 1
              },
              new ProductImage()
              {
                  Image = "yeezy-boost-700-mauve-2.jpeg",
                  ProductId = 1
              },
              new ProductImage()
              {
                  Image = "yeezy-boost-700-mauve-3.jpeg",
                  ProductId = 1
              },
              new ProductImage()
              {
                  Image = "yeezy-boost-700-mauve-4.jpeg",
                  ProductId = 1
              },
              new ProductImage()
              {
                  Image = "yeezy-boost-700-mauve-5.jpeg",
                  ProductId = 1
              },
              new ProductImage()
              {
                  Image = "yeezy-boost-700-mauve-6.jpeg",
                  ProductId = 1
              },
              new ProductImage()
              {
                  Image = "yeezy-boost-700-mauve-7.jpeg",
                  ProductId = 1
              },
              new ProductImage()
              {
                  Image = "yeezy-boost-700-mauve-8.jpeg",
                  ProductId = 1
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-1.jpeg",
                  ProductId = 2
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-2.jpeg",
                  ProductId = 2
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-3.jpeg",
                  ProductId = 2
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-4.jpeg",
                  ProductId = 2
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-5.jpeg",
                  ProductId = 2
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-6.jpeg",
                  ProductId = 2
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-7.jpeg",
                  ProductId = 2
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-8.jpeg",
                  ProductId = 2
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-9.jpeg",
                  ProductId = 2
              },
              new ProductImage()
              {
                  Image = "yeezy-knit-runner-sulfur-10.jpeg",
                  ProductId = 2
              }
              ,
              new ProductImage()
              {
                  Image = "yeezy-foam-runner-ochre-1.jpg",
                  ProductId = 3
              },
              new ProductImage()
              {
                  Image = "yeezy-foam-runner-ochre-2.jpg",
                  ProductId = 3
              },
              new ProductImage()
              {
                  Image = "yeezy-foam-runner-ochre-3.jpg",
                  ProductId = 3
              },
              new ProductImage()
              {
                  Image = "yeezy-foam-runner-ochre-4.jpg",
                  ProductId = 3
              },
              new ProductImage()
              {
                  Image = "yeezy-foam-runner-ochre-5.jpg",
                  ProductId = 3
              },
              new ProductImage()
              {
                  Image = "yeezy-foam-runner-ochre-6.jpg",
                  ProductId = 3
              },
              new ProductImage()
              {
                  Image = "yeezy-foam-runner-ochre-7.jpg",
                  ProductId = 3
              },
              new ProductImage()
              {
                  Image = "yeezy-foam-runner-ochre-8.jpg",
                  ProductId = 3
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-1.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-2.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-3.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-4.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-5.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-6.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-7.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-8.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-9.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "yeezy-450-dark-slate-10.jpeg",
                  ProductId = 4
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-1.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-2.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-3.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-4.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-5.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-6.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-7.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-8.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-9.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "Yeezy-Boost-350-V2-Mono-Cinder-10.jpeg",
                  ProductId = 5
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-university-blue-1.jpeg",
                  ProductId = 6
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-university-blue-2.jpeg",
                  ProductId = 6
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-university-blue-3.jpeg",
                  ProductId = 6
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-university-blue-4.jpeg",
                  ProductId = 6
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-university-blue-5.jpeg",
                  ProductId = 6
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-university-blue-6.jpeg",
                  ProductId = 6
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-university-blue-7.jpeg",
                  ProductId = 6
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-university-blue-8.jpeg",
                  ProductId = 6
              },
              new ProductImage()
              {
                  Image = "air-jordan-4-retro-lightning-2021-1.jpeg",
                  ProductId = 7
              },
              new ProductImage()
              {
                  Image = "air-jordan-4-retro-lightning-2021-2.jpeg",
                  ProductId = 7
              },
              new ProductImage()
              {
                  Image = "air-jordan-4-retro-lightning-2021-3.jpeg",
                  ProductId = 7
              },
              new ProductImage()
              {
                  Image = "air-jordan-4-retro-lightning-2021-4.jpeg",
                  ProductId = 7
              },
              new ProductImage()
              {
                  Image = "air-jordan-4-retro-lightning-2021-5.jpeg",
                  ProductId = 7
              },
              new ProductImage()
              {
                  Image = "air-jordan-4-retro-lightning-2021-6.jpeg",
                  ProductId = 7
              },
              new ProductImage()
              {
                  Image = "air-jordan-4-retro-lightning-2021-7.jpeg",
                  ProductId = 7
              },
              new ProductImage()
              {
                  Image = "air-jordan-4-retro-lightning-2021-8.jpeg",
                  ProductId = 7
              },
              new ProductImage()
              {
                  Image = "air-jordan-5-retro-gs-raging-bull-2021-1.jpeg",
                  ProductId = 8
              },
              new ProductImage()
              {
                  Image = "air-jordan-5-retro-gs-raging-bull-2021-2.jpeg",
                  ProductId = 8
              },
              new ProductImage()
              {
                  Image = "air-jordan-5-retro-gs-raging-bull-2021-3.jpeg",
                  ProductId = 8
              },
              new ProductImage()
              {
                  Image = "air-jordan-5-retro-gs-raging-bull-2021-4.jpeg",
                  ProductId = 8
              },
              new ProductImage()
              {
                  Image = "air-jordan-5-retro-gs-raging-bull-2021-5.jpeg",
                  ProductId = 8
              },
              new ProductImage()
              {
                  Image = "air-jordan-5-retro-gs-raging-bull-2021-6.jpeg",
                  ProductId = 8
              },
              new ProductImage()
              {
                  Image = "air-jordan-5-retro-gs-raging-bull-2021-7.jpeg",
                  ProductId = 8
              },
              new ProductImage()
              {
                  Image = "air-jordan-5-retro-gs-raging-bull-2021-8.jpeg",
                  ProductId = 8
              },
              new ProductImage()
              {
                  Image = "air-jordan-11-retro-bred-1.jpeg",
                  ProductId = 9
              },
              new ProductImage()
              {
                  Image = "air-jordan-11-retro-bred-2.jpeg",
                  ProductId = 9
              },
              new ProductImage()
              {
                  Image = "air-jordan-11-retro-bred-3.jpeg",
                  ProductId = 9
              },
              new ProductImage()
              {
                  Image = "air-jordan-11-retro-bred-4.jpeg",
                  ProductId = 9
              },
              new ProductImage()
              {
                  Image = "air-jordan-11-retro-bred-5.jpeg",
                  ProductId = 9
              },
              new ProductImage()
              {
                  Image = "air-jordan-11-retro-bred-6.jpeg",
                  ProductId = 9
              },
              new ProductImage()
              {
                  Image = "air-jordan-11-retro-bred-7.jpeg",
                  ProductId = 9
              },
              new ProductImage()
              {
                  Image = "air-jordan-11-retro-bred-8.jpeg",
                  ProductId = 9
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-ps-seafoam-1.jpeg",
                  ProductId = 10
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-ps-seafoam-2.jpeg",
                  ProductId = 10
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-ps-seafoam-3.jpeg",
                  ProductId = 10
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-ps-seafoam-4.jpeg",
                  ProductId = 10
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-ps-seafoam-5.jpeg",
                  ProductId = 10
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-ps-seafoam-6.jpeg",
                  ProductId = 10
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-ps-seafoam-7.jpeg",
                  ProductId = 10
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-ps-seafoam-8.jpeg",
                  ProductId = 10
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-dark-marina-blue-1.jpeg",
                  ProductId = 11
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-dark-marina-blue-2.jpeg",
                  ProductId = 11
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-dark-marina-blue-3.jpeg",
                  ProductId = 11
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-dark-marina-blue-4.jpeg",
                  ProductId = 11
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-dark-marina-blue-5.jpeg",
                  ProductId = 11
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-dark-marina-blue-6.jpeg",
                  ProductId = 11
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-dark-marina-blue-7.jpeg",
                  ProductId = 11
              },
              new ProductImage()
              {
                  Image = "air-jordan-1-retro-high-og-dark-marina-blue-8.jpeg",
                  ProductId = 11
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-1.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-2.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-3.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-4.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-5.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-6.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-7.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-8.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-9.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-10.jpeg",
                  ProductId = 12
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-OG-1.jpeg",
                  ProductId = 13
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-OG-2.jpeg",
                  ProductId = 13
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-OG-3.jpeg",
                  ProductId = 13
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-OG-4.jpeg",
                  ProductId = 13
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-OG-5.jpeg",
                  ProductId = 13
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-OG-6.jpeg",
                  ProductId = 13
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-OG-7.jpeg",
                  ProductId = 13
              },
              new ProductImage()
              {
                  Image = "ultra-4d-5-0-carbon-1.jpeg",
                  ProductId = 14
              },
              new ProductImage()
              {
                  Image = "ultra-4d-5-0-carbon-2.jpeg",
                  ProductId = 14
              },
              new ProductImage()
              {
                  Image = "ultra-4d-5-0-carbon-3.jpeg",
                  ProductId = 14
              },
              new ProductImage()
              {
                  Image = "ultra-4d-5-0-carbon-4.jpeg",
                  ProductId = 14
              },
              new ProductImage()
              {
                  Image = "ultra-4d-5-0-carbon-5.jpeg",
                  ProductId = 14
              },
              new ProductImage()
              {
                  Image = "ultra-4d-5-0-carbon-6.jpeg",
                  ProductId = 14
              },
              new ProductImage()
              {
                  Image = "ultra-4d-5-0-carbon-7.jpeg",
                  ProductId = 14
              },
              new ProductImage()
              {
                  Image = "ultra-4d-5-0-carbon-8.jpeg",
                  ProductId = 14
              },
              new ProductImage()
              {
                  Image = "ultra-4d-grey-pink-gradient-1.jpeg",
                  ProductId = 15
              },
              new ProductImage()
              {
                  Image = "ultra-4d-grey-pink-gradient-2.jpeg",
                  ProductId = 15
              },
              new ProductImage()
              {
                  Image = "ultra-4d-grey-pink-gradient-3.jpeg",
                  ProductId = 15
              },
              new ProductImage()
              {
                  Image = "ultra-4d-grey-pink-gradient-4.jpeg",
                  ProductId = 15
              },
              new ProductImage()
              {
                  Image = "ultra-4d-grey-pink-gradient-5.jpeg",
                  ProductId = 15
              },
              new ProductImage()
              {
                  Image = "ultra-4d-grey-pink-gradient-6.jpeg",
                  ProductId = 15
              },
              new ProductImage()
              {
                  Image = "ultra-4d-grey-pink-gradient-7.jpeg",
                  ProductId = 15
              },
              new ProductImage()
              {
                  Image = "ultra-4d-grey-pink-gradient-8.jpeg",
                  ProductId = 15
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-Chalk-White-1.jpeg",
                  ProductId = 16
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-Chalk-White-2.jpeg",
                  ProductId = 16
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-Chalk-White-3.jpeg",
                  ProductId = 16
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-Chalk-White-4.jpeg",
                  ProductId = 16
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-Chalk-White-5.jpeg",
                  ProductId = 16
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-Chalk-White-6.jpeg",
                  ProductId = 16
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-Chalk-White-7.jpeg",
                  ProductId = 16
              },
              new ProductImage()
              {
                  Image = "Ultra-4D-Chalk-White-8.jpeg",
                  ProductId = 16
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-2.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-3.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-4.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-5.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-6.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-7.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-8.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-9.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "atmos-x-LeBron 18-Low-'Sakura'-10.jpeg",
                  ProductId = 18
              },
              new ProductImage()
              {
                  Image = "Little-Posite-One-GS-Twilight-Pulse-1.png",
                  ProductId = 19
              },
              new ProductImage()
              {
                  Image = "little-posite-one-xx-royal-1.png",
                  ProductId = 20
              },
              new ProductImage()
              {
                  Image = "kyrie-5-ep-have-a-nike-day-1.png",
                  ProductId = 21
              },
              new ProductImage()
              {
                  Image = "zoom-kd-12-wolf-grey-1.jpeg",
                  ProductId = 22
              },
              new ProductImage()
              {
                  Image = "zoom-kd-12-wolf-grey-2.jpeg",
                  ProductId = 22
              },
              new ProductImage()
              {
                  Image = "zoom-kd-12-wolf-grey-3.jpeg",
                  ProductId = 22
              },
              new ProductImage()
              {
                  Image = "zoom-kd-12-wolf-grey-4.jpeg",
                  ProductId = 22
              },
              new ProductImage()
              {
                  Image = "zoom-kd-12-wolf-grey-5.jpeg",
                  ProductId = 22
              },
              new ProductImage()
              {
                  Image = "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-1.jpeg",
                  ProductId = 23
              },
              new ProductImage()
              {
                  Image = "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-2.jpeg",
                  ProductId = 23
              },
              new ProductImage()
              {
                  Image = "supreme-x-the-north-face-faux-fur-nuptse-jacket-red-3.jpeg",
                  ProductId = 23
              },
              new ProductImage()
              {
                  Image = "supreme-x-nike-half-zip-hooded-sweatshirt-white-2.jpeg",
                  ProductId = 24
              },
              new ProductImage()
              {
                  Image = "supreme-x-nike-half-zip-hooded-sweatshirt-white-1.jpeg",
                  ProductId = 24
              },
              new ProductImage
              {
                  Image = "supreme-saint-michael-fleece-jacket-white-1.jpeg",
                  ProductId = 25
              },
              new ProductImage
              {
                  Image = "supreme-saint-michael-fleece-jacket-white-2.jpeg",
                  ProductId = 25
              },
              new ProductImage
              {
                  Image = "supreme-saint-michael-fleece-jacket-white-3.jpeg",
                  ProductId = 25
              },
              new ProductImage
              {
                  Image = "supreme-x-the-north-face-cargo-jacket-gold.jpeg",
                  ProductId = 26
              },
              new ProductImage
              {
                  Image = "supreme-x-the-north-face-s-logo-mountain-jacket-black-1.jpeg",
                  ProductId = 27
              },
              new ProductImage
              {
                  Image = "supreme-x-the-north-face-s-logo-mountain-jacket-black-2.jpeg",
                  ProductId = 27
              },
              new ProductImage
              {
                  Image = "supreme-x-the-north-face-s-logo-mountain-jacket-black-3.jpeg",
                  ProductId = 27
              },
              new ProductImage()
              {
                  Image = "fear-of-god-essentials-kids-short-sleeve-polo-stretch-limo.jpeg",
                  ProductId = 28
              },
              new ProductImage()
              {
                  Image = "fear-of-god-essentials-kids-pullover-hoodie-stretch-limo.jpeg",
                  ProductId = 29
              },
              new ProductImage()
              {
                  Image = "fear-of-god-essentials-kids-sweatpant-stretch-limo.jpeg",
                  ProductId = 30
              },
              new ProductImage()
              {
                  Image = "fear-of-god-essentials-rc-9fifty-cap-black-1.jpeg",
                  ProductId = 31
              },
              new ProductImage()
              {
                  Image = "fear-of-god-essentials-rc-9fifty-cap-black-2.jpeg",
                  ProductId = 31
              },
              new ProductImage()
              {
                  Image = "fear-of-god-essentials-x-mr-porter-exclusive-hoodie-vicunia.jpeg",
                  ProductId = 32
              }
            );
            #endregion
            #region user
            var superAdminGuid = "096149B4-92AA-4D5F-89AB-579244023AE6";
            var adminGuid = "218A643E-C736-4680-B8FC-6464F3E4B963";
            var defaultUserGuid = "B9685628-AA98-4A0F-9A97-F872A932F211";
            var customer1Guid = "3EBC9915-5931-471B-8CDB-A1B5B10B6088";
            var customer2Guid = "FA12454E-EBC4-4EB8-9290-93DDDCC94BDE";
            var customer3Guid = "F408EA82-601A-4573-9A68-C0E31FD87623";
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = new Guid(superAdminGuid),
                    UserName = "superAdmin",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    Email = "superadmin@superadmin.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                },
                new User()
                {
                    Id = new Guid(adminGuid),
                    UserName = "admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword123"),
                    Email = "admin@admin.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                },
                new User()
                {
                    Id = new Guid(defaultUserGuid),
                    UserName = "defaultuser",
                    PasswordHash = hasher.HashPassword(null, "P@ssword123"),
                    Email = "user@user.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                },
                new User()
                {
                    Id = new Guid(customer1Guid),
                    UserName = "customer1",
                    PasswordHash = hasher.HashPassword(null, "P@ssword123"),
                    Email = "customer1@customer1.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                },
                new User()
                {
                    Id = new Guid(customer2Guid),
                    UserName = "customer2",
                    PasswordHash = hasher.HashPassword(null, "P@ssword123"),
                    Email = "customer2@customer2.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                },
                new User()
                {
                    Id = new Guid(customer3Guid),
                    UserName = "customer3",
                    PasswordHash = hasher.HashPassword(null, "P@ssword123"),
                    Email = "customer3@customer3.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                });
            #endregion
            #region role
            var superAdminRoleGuid = "B610DD6A-D83E-4937-9E7C-700512654CA2";
            var adminRoleGuid = "0151BF94-13D6-4CB7-A815-43CDB359413B";
            var userRoleGuid = "BB64CBE4-5757-40EA-8533-980A148E3369";
            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid>
                {
                    Id = new Guid(superAdminRoleGuid),
                    Name = "SuperAdmin",
                    NormalizedName = "superadmin"
                },
                new IdentityRole<Guid>
                {
                    Id = new Guid(adminRoleGuid),
                    Name = "admin",
                    NormalizedName = "admin"
                },
                new IdentityRole<Guid>
                {
                    Id = new Guid(userRoleGuid),
                    Name = "user",
                    NormalizedName = "user"
                }
            );
            #endregion
            #region user with role
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid(superAdminRoleGuid),
                    UserId = new Guid(superAdminGuid)
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid(adminRoleGuid),
                    UserId = new Guid(adminGuid)
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid(userRoleGuid),
                    UserId = new Guid(customer1Guid)
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid(userRoleGuid),
                    UserId = new Guid(customer2Guid)
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = new Guid(userRoleGuid),
                    UserId = new Guid(customer3Guid)
                }
            );
            #endregion

        }
    }
}