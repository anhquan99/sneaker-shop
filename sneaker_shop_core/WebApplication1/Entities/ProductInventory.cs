namespace WebApplication1.Entities
{
    public class ProductInventory
    {
        public int Id { get; set; } 
        public int ProductId { get; set;}
        public virtual Product Product { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiledAt { get; set; }
        public virtual List<ProductPrice> Price { get; set; } 
    }
}
