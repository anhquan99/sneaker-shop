namespace WebApplication1.Entities
{
    public class CardSession
    {
        public int ID { get; set; } 
        public User User { get; set; }
        public double Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }
        public List<CardItem> Items { get; set; }
    }
}
