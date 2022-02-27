using WebApplication1.Entities;
using WebApplication1.Infrastructure.Enums;
using WebApplication1.Infrastructure.Extensions;

namespace WebApplication1.Data.Seeding
{
    public static class DataModelSeedingExtensions
    {
        private const string datetimeFormat = "dd-mm-yyyy";
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
                    NameId = "SUPREME",
                    Icon = "",
                    Story = "Founded by James Jebbia in 1994, Supreme is a New York-based skate brand known for its subcultural references and controversial graphics. Today, Supreme is considered one of style’s most influential voices, blurring the lines between streetwear and luxury through collaborations with artists, fashion houses and sneaker brands."
                },
                new BrandSilhouette()
                {
                    CreatedAt = DateTime.Now,
                    NameId = "YEEZY",
                    Icon = "",
                    Story = "In late 2013, Kanye West and adidas announced their forthcoming partnership. In 2015, the two delivered on this news, arriving in the form of Yeezy Season 1, a collection of sneakers and apparel debuted at New York Fashion Week. Since the first collection, Yeezy has influenced style movements worldwide."
                }
            };
            var products = new List<Product>()
            {
                new Product()
                {
                    Name = "Yeezy Boost 700 V2 'Mauve'",
                    CreatedAt = DateTime.Now,
                    Releasedate = DateTime.Parse("09-26-2021"),
                    BrandSilhouetteID = "YEEZY",
                    Category = EnumExtensionMethods.getEnumDescription(CategoriesEnum.Boots),
                    Color = "Tan",
                    Type = EnumExtensionMethods.getEnumDescription(ProductTypesEnum.Sneaker),
                    UserType = EnumExtensionMethods.getEnumDescription(UserTypesEnum.Men),
                    CoverImage = "",
                    Description = "The adidas Yeezy Boost 700 V2 ‘Mauve’ brings back a popular colorway first seen on a Yeezy Boost 700 release from 2018. The sneaker’s titular hue is executed on a textured mesh upper with arcing no-sew skins along the quarter panel and greenish-grey suede overlays throughout. Responsive cushioning comes courtesy of a full-length drop-in Boost midsole, housed within a sculpted polyurethane carrier. Underfoot, a herringbone-traction rubber outsole provides optimal grip.",

                }
            }
        }
    }
}
