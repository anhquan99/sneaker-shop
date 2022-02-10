namespace WebApplication1.Entities
{
    public class ProductInventory
    {
        public Product Product { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiledAt { get; set; }
        public ProductPrice Price { get; set; } 
    }
}
