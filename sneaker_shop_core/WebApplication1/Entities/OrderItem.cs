namespace WebApplication1.Entities
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }  
        public virtual Order Order { get; set; }    
        public virtual Product Product { get; set; }    
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }
    }
}
