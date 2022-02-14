namespace WebApplication1.Entities
{
    public class Product
    {
        public int Id { get; set; }    
        public string Name { get; set; }    
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public string Wallpaper { get; set; }
        public DateTime Releasedate { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public string UserType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string BrandSilhouetteID { get; set; }
        public virtual BrandSilhouette BrandSilhouette { get; set; }
        public virtual List<Discount> Discount  { get; set; }
        public virtual List<ProductImage> ProductImages { get; set; }
        public virtual ProductInventory ProductInventory { get; set; }
        public virtual List<CartItem> CardItems { get; set; }   
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<WantedProduct> WantedProducts { get; set; }

    }
}
