namespace WebApplication1.Entities
{
    public class ProductImage
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }    
        public string Image { get; set; }
    }
}
