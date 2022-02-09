namespace WebApplication1.Entities
{
    public class Product
    {
        public int Id { get; set; }    
        public string Name { get; set; }    
        public string ? Description { get; set; }
        public string ? CoverImage { get; set; }
        public string Wallpaper { get; set; }
        public DateOnly Releasedate { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public string UserType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }
        public BrandSilhouette BrandSilhouette { get; set; }
        public Discount Discount  { get; set; }
    }
}
