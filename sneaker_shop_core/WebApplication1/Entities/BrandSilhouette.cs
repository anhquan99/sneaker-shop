namespace WebApplication1.Entities
{
    public class BrandSilhouette
    {
        public string NameId { get; set; }
        public string Story { get; set; }
        public string Icon { get; set; }
        public virtual List<Product> Products { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}
