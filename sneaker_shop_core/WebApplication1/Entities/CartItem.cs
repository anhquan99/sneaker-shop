namespace WebApplication1.Entities
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int CartSessionId { get; set; }
        public virtual Product Product { get; set; } 
        public virtual CartSession Session { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }
    }
}
