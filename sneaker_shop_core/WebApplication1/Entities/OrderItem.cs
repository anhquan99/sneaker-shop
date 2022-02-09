namespace WebApplication1.Entities
{
    public class OrderItem
    {
        public Order Order { get; set; }    
        public Product Product { get; set; }    
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }
    }
}
