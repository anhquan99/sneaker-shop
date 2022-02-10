namespace WebApplication1.Entities
{
    public class BrandSilhouette
    {
        public string NameID { get; set; }
        public string ? Story { get; set; }
        public string Icon { get; set; }
        public List<Product> Products { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }

    }
}
