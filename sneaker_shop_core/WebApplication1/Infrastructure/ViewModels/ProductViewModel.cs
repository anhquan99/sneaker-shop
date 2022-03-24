using WebApplication1.Infrastructure.Enums;
using WebApplication1.Infrastructure.Extensions;

namespace WebApplication1.Infrastructure.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public string Color { get; set; }
        public List<string> Brand { get; set; }
        public string Silhouette { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public List<string> Images { get; set; }
        public ProductViewModel(Product product)
        {
            Name = product.Name;
            Description = product.Description;
            ReleaseDate = product.Releasedate.ToString("yyyy-MM-dd");
            Color = product.Color;
            Category = product.Category;
            Brand = product.BrandSilhouette.Where(x => x.Type.Equals(EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Brand))).Select(x => x.NameId).ToList();
            Silhouette = product.BrandSilhouette.Where(x => x.Type.Equals(EnumExtensionMethods.getEnumDescription(BrandSilhouetteEnum.Silhouette))).Select(x => x.NameId).FirstOrDefault();
            Images = product.ProductImages.OrderBy(x => x.Image).Select(x => x.Image).ToList();
        }
    }
}
