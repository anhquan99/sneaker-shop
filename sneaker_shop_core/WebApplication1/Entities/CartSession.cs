namespace WebApplication1.Entities
{
    public class CartSession
    {
        public int Id { get; set; } 
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public double Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }
        public virtual List<CartItem> Items { get; set; }
    }
}
