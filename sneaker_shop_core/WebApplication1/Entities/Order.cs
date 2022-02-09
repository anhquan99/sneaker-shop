namespace WebApplication1.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public User User { get; set; }
        public double Total { get; set; }
        public PaymentDetail PaymentDetail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ? ModifiedAt { get; set; }

    }
}
