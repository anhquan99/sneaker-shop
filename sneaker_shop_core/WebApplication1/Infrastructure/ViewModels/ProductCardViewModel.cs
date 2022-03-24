namespace WebApplication1.Infrastructure.ViewModels
{
    public class ProductCardViewModel
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string ReleaseDate { get; set; }
        public ProductCardViewModel(Product product)
        {
            this.Name = product.Name;
            this.Image = product.CoverImage;
            this.ReleaseDate = product.Releasedate.ToString("dd MMMM");
        }
    }
}
