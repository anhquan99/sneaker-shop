namespace WebApplication1.Entities
{
    public class CardItem
    {
        public Product Product { get; set; } 
        public CardSession Session { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }
    }
}
