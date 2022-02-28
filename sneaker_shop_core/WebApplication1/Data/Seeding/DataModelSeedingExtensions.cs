using WebApplication1.Entities;
using WebApplication1.Infrastructure.Enums;
using WebApplication1.Infrastructure.Extensions;

namespace WebApplication1.Data.Seeding
{
    public static class DataModelSeedingExtensions
    {
        //private const string datetimeFormat = "dd-mm-yyyy";
        public static void Seed(this ApplicationDbContext dbContext)
        {
            var brands = new List<BrandSilhouette>
            {
                new BrandSilhouette()
                {
                    CreatedAt = DateTime.Now,
                    Icon = "",
                    NameId = "Adidas",
                    Story = "Adi Dassler founded adidas in 1949 in Herzogenaurach, Germany. Building on the reputation of the brand’s spiked running shoes and football cleats, Dassler turned adidas into a global icon, redefining sneakers and apparel in the process. Today, adidas is considered one of the world’s most influential brands, responsible for the Stan Smith, Yeezy sneakers and more."
                },
                new BrandSilhouette()
                {
                    CreatedAt = DateTime.Now,
                    NameId = "Nike",
                    Icon = "",
                    Story = "Founded by Bill Bowerman and Phil Knight in 1964, Nike is synonymous with performance and innovation. Alongside its apparel offerings, the sportswear giant is responsible for a number of iconic sneakers, including the Air Force 1, the Air Max franchise and more. Today, Nike is among the world’s most recognized brands, identified by its wordmark and Swoosh logo."
                },
                new BrandSilhouette()
                {
                    CreatedAt = DateTime.Now,
                    NameId = "Air Jordan",
                    Icon = "",
                    Story = "In 1984, Nike unveiled the Air Jordan 1, a basketball sneaker designed by Peter Moore for a young Michael Jordan. The iconic silhouette transcended sneakers and sports, altering the trajectory of style forever. Today, Michael Jordan’s namesake brand continues to inspire sportswear and style movements around the world through new releases, retro drops and unexpected collaborations."
                },
                new BrandSilhouette()
                {
                    CreatedAt = DateTime.Now,
                    NameId = "Supreme",
                    Icon = "",
                    Story = "Founded by James Jebbia in 1994, Supreme is a New York-based skate brand known for its subcultural references and controversial graphics. Today, Supreme is considered one of style’s most influential voices, blurring the lines between streetwear and luxury through collaborations with artists, fashion houses and sneaker brands."
                },
                new BrandSilhouette()
                {
                    CreatedAt = DateTime.Now,
                    NameId = "Yeezy",
                    Icon = "",
                    Story = "In late 2013, Kanye West and adidas announced their forthcoming partnership. In 2015, the two delivered on this news, arriving in the form of Yeezy Season 1, a collection of sneakers and apparel debuted at New York Fashion Week. Since the first collection, Yeezy has influenced style movements worldwide."
                },
                new BrandSilhouette()
                {
                    CreatedAt = DateTime.Now,
                    NameId = "Fear of God Essentials",
                    Icon = "",
                    Story = "In 2018, Jerry Lorenzo launched Fear of God Essentials, a pared-back version of Fear of God. Each seasonal collection brings the line’s concept into sharper focus, uniting elevated sportswear basics with subdued shades and minimal branding."
                }
            };
            var products = new List<Product>()
            {
                new Product()
                {
                    Name = "Yeezy Boost 700 V2 'Mauve'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-26-2021"),
                    BrandSilhouetteID = "Yeezy",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Boots),
                    Color = "Tan",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The adidas Yeezy Boost 700 V2 ‘Mauve’ brings back a popular colorway first seen on a Yeezy Boost 700 release from 2018. The sneaker’s titular hue is executed on a textured mesh upper with arcing no-sew skins along the quarter panel and greenish-grey suede overlays throughout. Responsive cushioning comes courtesy of a full-length drop-in Boost midsole, housed within a sculpted polyurethane carrier. Underfoot, a herringbone-traction rubber outsole provides optimal grip.",
                    Id = 1
                },
                new Product()
                {
                    Name = "Yeezy Knit Runner 'Sulfur'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-24-2021"),
                    BrandSilhouetteID = "Yeezy",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Sulfur",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The adidas Yeezy Knit Runner ‘Sulfur’ delivers the debut colorway of Kanye West’s sock-like silhouette, which launched exclusively through the artist’s Yeezy Supply site. The fully knit build, rendered in a neutral tan shade with a contrasting mustard yellow finish throughout the majority of the upper, utilizes slip-on construction devoid of exterior branding. Embellishments are limited to sizing information stamped on the lateral collar. The sneaker rides on a durable rubber outsole in a matching yellow finish, featuring a modified herringbone tread and adidas branding under the heel.",
                    Id = 2
                },
                new Product()
                {
                    Name = "Yeezy Foam Runner 'Ochre'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-19-2021"),
                    BrandSilhouetteID = "Yeezy",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Yellow",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The adidas Yeezy Foam Runner ‘Ochre’ complements its futuristic aesthetic with a subdued, monochromatic finish. A dark beige hue suffuses the one-piece foam build, featuring ventilation ports of varying shapes and dimensions that enhance breathability while adding depth to the slip-on’s flowing lines. ‘FOAM RNNR’ is debossed on the interior collar, alongside the shoe size and ‘Made in USA’ branding. Underfoot, the outsole features a wavy traction pattern for reliable grip.",
                    Id = 3
                },
                new Product()
                {
                    Name = "Yeezy 450 'Dark Slate'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("06-27-2021"),
                    BrandSilhouetteID = "Yeezy",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The adidas Yeezy 450 ‘Dark Slate’ delivers a blacked-out iteration of Kanye West’s boundary-pushing silhouette. Stripped of color and exterior branding, the knit upper is secured with an integrated lacing system and topped with an elastic, sock-like cuff. In lieu of a traditional midsole, the rubber outsole sprouts tapered appendages that wrap up the heel and side panels of the deconstructed build, providing support and enhanced durability within its grasp.",
                    Id = 4
                },
                new Product()
                {
                    Name = "Yeezy Boost 350 V2 'Mono Cinder'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("06-25-2021"),
                    BrandSilhouetteID = "Yeezy",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "Launching as part of a four-piece ‘Mono’ pack, the adidas Yeezy Boost 350 V2 ‘Mono Cinder’ applies a black-out finish to the lifestyle sneaker. The revised design features an upper crafted from monofilament mesh, reinforced with an interior cage and accented with a tonal lateral side stripe. A webbing pull tab at the heel allows the sock-like build to be easily slipped on and off. The stealthy palette extends to the midsole, featuring wrapped Boost cushioning that runs the length of the rubber outsole. This shoe released exclusively on Yeezy Supply.",
                    Id = 5
                },
                new Product()
                {
                    Name = "Air Jordan 1 Retro High OG 'University Blue'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("03-07-2021"),
                    BrandSilhouetteID = "Air Jordan",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Blue",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The Air Jordan 1 Retro High OG ‘University Blue’ makes use of a familiar palette that gives the nod to Michael Jordan’s UNC alma mater. The all-leather upper features a white base with powder blue overlays and a black signature Swoosh. Matching black accents make their way to the collar, tongue tag and printed Wings logo on the lateral collar flap. A brighter shade of blue is applied to the standard AJ1 outsole, featuring multi-directional traction and a pivot point under the forefoot.",
                    Id = 6
                },
                new Product()
                {
                    Name = "Air Jordan 4 Retro 'Lightning' 2021",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("08-29-2021"),
                    BrandSilhouetteID = "Air Jordan",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Yellow",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The 2021 edition of the Air Jordan 4 Retro ‘Lightning’ resurrects a highly coveted colorway that originally launched in 2006 alongside an accompanying ‘Thunder’ colorway, both of which were inspired by Michael Jordan’s Motorsports team. A bright yellow hue floods the nubuck upper, contrasted by black netting and dark grey structural wings. Matching grey accents land on the woven tongue tag, interior tongue and Jumpman branding at the heel. A white PU midsole, enhanced with visible Air sole cushioning, rides on a dark grey herringbone rubber outsole.",
                    Id = 7
                },
                new Product()
                {
                    Name = "Air Jordan 5 Retro 'Raging Bull' 2021",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("04-11-2021"),
                    BrandSilhouetteID = "Air Jordan",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Red",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The 2021 reissue of the Air Jordan 5 Retro ‘Raging Bull’ brings back a beloved colorway originally released as one-half of 2009’s Air Jordan 5 Raging Bulls Pack. The shoe’s defining feature is a plush Varsity Red suede upper, equipped with black eyelets and a Jumpman-branded reflective silver tongue. The heel overlay displays a second Jumpman logo and an embroidered 23 on the lateral side. A visible Nike Air heel unit enhances the polyurethane midsole, accented with red-tipped shark tooth detailing and supported by an icy translucent outsole.",
                    Id = 8
                },
                new Product()
                {
                    Name = "Air Jordan 11 Retro 'Bred' 2019",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("12-15-2019"),
                    BrandSilhouetteID = "Air Jordan",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Red",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The Air Jordan 11 Retro 'Bred' 2019 brings back an original colorway initially debuted in 1995. The Tinker Hatfield-designed silhouette features Chicago Bulls colors, with black mesh on the upper sitting atop shiny black patent leather. A white midsole melds nicely with a translucent Varsity Red outsole, and is the same colorway that Michael Jordan wore during the 1996 NBA championship playoff run. This retro was distributed in December 2019 with OG detailing, including high-cut patent leather, signature Jumpman branding and MJ's number 23 stamped on the heel.",
                    Id = 8
                },
                new Product()
                {
                    Name = "Air Jordan 1 Retro High OG PS 'Seafoam'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("08-13-2021"),
                    BrandSilhouetteID = "Air Jordan",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Green",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "",
                    Description = "Crafted for little kids, the Air Jordan 1 Retro High OG PS ‘Seafoam’ updates the iconic silhouette with a two-tone palette geared for the warm weather months. The upper is constructed from clean white leather with contrasting nubuck overlays in a pale green finish. The same pastel hue is repeated on the signature Swoosh, Nike branded tongue tag and durable rubber outsole. Woven white laces are outlined in reddish bronze for an unexpected pop of contrasting color.",
                    Id = 9
                },
                new Product()
                {
                    Name = "Air Jordan 1 Retro High OG 'Dark Marina Blue'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("02-17-2022"),
                    BrandSilhouetteID = "Air Jordan",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Blue",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The Air Jordan 1 Retro High OG ‘Dark Marina Blue’ dresses the iconic silhouette in classic two-tone color blocking. The all-leather upper features a black base with contrasting dark blue overlays along the forefoot, heel, collar and eyestay. A matching blue Swoosh is accompanied by a Jordan Wings logo stamped in black on the lateral collar flap. Atop the nylon tongue, a woven Nike Air tag nods to the shoe’s retro cushioning technology: an Air-sole unit encapsulated in polyurethane nestled in the heel of the rubber cupsole.",
                    Id = 10
                },
                new Product()
                {
                    Name = "Air Jordan 1 Retro High OG 'Dark Marina Blue'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("02-17-2022"),
                    BrandSilhouetteID = "Air Jordan",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.LifeStyle),
                    Color = "Blue",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The Air Jordan 1 Retro High OG ‘Dark Marina Blue’ dresses the iconic silhouette in classic two-tone color blocking. The all-leather upper features a black base with contrasting dark blue overlays along the forefoot, heel, collar and eyestay. A matching blue Swoosh is accompanied by a Jordan Wings logo stamped in black on the lateral collar flap. Atop the nylon tongue, a woven Nike Air tag nods to the shoe’s retro cushioning technology: an Air-sole unit encapsulated in polyurethane nestled in the heel of the rubber cupsole.",
                    Id = 11
                },
                new Product()
                {
                    Name = "Ultra 4D 'OG'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("08-14-2020"),
                    BrandSilhouetteID = "Adidas",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The adidas Ultra 4D ‘OG’ borrows a familiar color scheme initially featured on the UltraBoost release from 2015. This pair replaces the signature Boost cushioning of the original with a futuristic adidas 4D midsole, using a lattice structure made with a blend of liquid resin, light and oxygen. Up top, a matching black knit build is reinforced with a tonal midfoot cage and contrasting purple heel counter marked with Ultra 4D branding.",
                    Id = 12
                },
                new Product()
                {
                    Name = "Ultra 4D 5.0 'Carbon'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("12-13-2020"),
                    BrandSilhouetteID = "Adidas",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The adidas Ultra 4D 5.0 ‘Carbon’ delivers a monotone take on a performance runner built on the brand’s revolutionary 3D-printed midsole, featuring a unique lattice structure crafted from a blend of light, oxygen and liquid resin. Up top, breathable Primeknit weaves together black and grey fibers to create unique patterns around the toe box and collar. Three-stripe branding is integrated into the midfoot cage, which works in tandem with a molded heel counter to provide added stability and support.",
                    Id = 13
                },
                new Product()
                {
                    Name = "Ultra 4D 'Grey Pink Gradient'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("02-27-2021"),
                    BrandSilhouetteID = "Adidas",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "Grey",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "",
                    Id = 13
                },
                new Product()
                {
                    Name = "Ultra 4D 'Chalk White'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("12-15-2020"),
                    BrandSilhouetteID = "Adidas",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "White",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "",
                    Id = 14
                },
                new Product()
                {
                    Name = "Ultra 4D 'Lemon Twist'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("12-04-2021"),
                    BrandSilhouetteID = "Adidas",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Running),
                    Color = "Cream",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "",
                    Id = 15
                },
                new Product()
                {
                    Name = "atmos x LeBron 18 Low 'Sakura'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("04-24-2021"),
                    BrandSilhouetteID = "Nike",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "Cream",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "Designed in partnership with the influential Tokyo-based retailer, the atmos x Nike LeBron 18 Low ‘Cherry Blossom’ showcases a spring-ready design, highlighted by a Swoosh formed with pink embroidered florals. The pastel hue is repeated on the sneaker’s molded eyelets and TPU heel counter, as well as a multicolor geometric print that enlivens the textile upper. The low-top sits on a cushy React foam midsole with a large-volume Max Air unit nestled under the heel.",
                    Id = 16
                },
                new Product()
                {
                    Name = "Little Posite One GS 'Twilight Pulse'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-02-2018"),
                    BrandSilhouetteID = "Nike",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "Orange",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The Nike Little Posite One GS ‘Twilight Pulse’ dresses Penny Hardaway’s signature shoe with a matte black finish on the molded synthetic upper. Metallic blue accents deliver contrasting color on the eyestay and collar trim, as does the bright orange shank plate integrated into the translucent sole unit. A mesh tongue and heel inlay provide breathable comfort while the attached pull loops are included for easy on and off.",
                    Id = 17
                },
                new Product()
                {
                    Name = "Little Posite One XX GS 'Royal'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-02-2018"),
                    BrandSilhouetteID = "Nike",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "Blue",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "Nike released a grade school exclusive to celebrate the 20th-anniversary of the Nike Air Foamposite One. The Little Posite One XX GS 'Royal' features a shiny Royal Blue Foamposite shell with black suede details on the eyestay and collar. The sneaker also boasts a carbon fiber midfoot arch, a mini white Swoosh on the forefoot, an icy blue translucent outsole, and a mesh inner sleeve for breathability and comfort.",
                    Id = 18
                },
                new Product()
                {
                    Name = "Kyrie 5 'Have A Nike Day'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("06-09-2019"),
                    BrandSilhouetteID = "Nike",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "White",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "A special edition of Kyrie Irving’s fifth model in his signature line, the Nike Kyrie 5 basketball shoe was one of the sneakers selected to be part of Nike’s celebratory 'Have A Nike Day' collection. Released in June 2019, the shoe is comprised of an engineered mesh upper for breathable, natural movement. The exterior is fitted with denim overlays, multicolored accents and Nike’s retro smiley face logo.",
                    Id = 19
                },
                new Product()
                {
                    Name = "Zoom KD 12 'Wolf Grey'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("06-08-2019"),
                    BrandSilhouetteID = "Nike",
                    Category = EnumExtensionMethods.getEnumDescription(SneakerCategoriesEnum.Basketball),
                    Color = "White",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "Doused in a 'Wolf Grey' colorway, the July 2019 Nike's Zoom KD 12 features a breathable and lightweight mesh upper with Flywire for lock-down, emulating the 'worn-in' feel NBA star Kevin Durant prefers. The shoe eliminates the more-typical strobel layer between the upper by stitching an iridescent, full-length Zoom Air unit directly to the upper increasing energy-return and spring on the court.",
                    Id = 20
                },
                new Product()
                {
                    Name = "Supreme x The North Face Faux Fur Nuptse Jacket 'Red'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2020"),
                    BrandSilhouetteID = "Supreme",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Red",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "",
                    Id = 21
                },
                new Product()
                {
                    Name = "Supreme x Nike Half Zip Hooded Sweatshirt 'White'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("03-12-2021"),
                    BrandSilhouetteID = "Supreme",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Red",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "",
                    Id = 22
                },
                new Product()
                {
                    Name = "Supreme Saint Michael Fleece Jacket 'White'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("04-02-2021"),
                    BrandSilhouetteID = "Supreme",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Multi-Color",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "",
                    Id = 23
                },
                new Product()
                {
                    Name = "Supreme x The North Face Cargo Jacket 'Gold'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-01-2020"),
                    BrandSilhouetteID = "Supreme",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Gold",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "",
                    Id = 24
                },
                new Product()
                {
                    Name = "Supreme x The North Face S Logo Mountain Jacket 'Black'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-01-2020"),
                    BrandSilhouetteID = "Supreme",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "",
                    Id = 25
                },
                new Product()
                {
                    Name = "Fear of God Essentials Kids Short-Sleeve Polo 'Stretch Limo'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    BrandSilhouetteID = "Fear of God Essentials",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Tops),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "",
                    Description = "",
                    Id = 26
                },
                new Product()
                {
                    Name = "Fear of God Essentials Kids Pullover Hoodie 'Stretch Limo'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    BrandSilhouetteID = "Fear of God Essentials",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "",
                    Description = "",
                    Id = 27
                },
                new Product()
                {
                    Name = "Fear of God Essentials Kids Sweatpant 'Stretch Limo'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    BrandSilhouetteID = "Fear of God Essentials",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Bottoms),
                    Color = "Black",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "",
                    Description = "",
                    Id = 28
                },
                new Product()
                {
                    Name = "Fear of God Essentials RC 9FIFTY Cap 'Black'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    BrandSilhouetteID = "Fear of God Essentials",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Accessories),
                    Color = "Brown",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "",
                    Description = "",
                    Id = 29
                },
                new Product()
                {
                    Name = "Fear of God Essentials Kids x Mr. Porter Exclusive Hoodie 'Vicunia'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("01-12-2021"),
                    BrandSilhouetteID = "Supreme",
                    Category = EnumExtensionMethods.getEnumDescription(ApperalCategoriesEnum.Outerwear),
                    Color = "Fear of God Essentials",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Apparel),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Youth),
                    CoverImage = "",
                    Description = "",
                    Id = 30
                },
            };
        }
    }
}
