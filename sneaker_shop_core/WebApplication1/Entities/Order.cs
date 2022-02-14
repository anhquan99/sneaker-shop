namespace WebApplication1.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }    
        public virtual User User { get; set; }
        public double Total { get; set; }
        public int PaymentDetailId { get; set; }
        public string status { get; set; }
        public PaymentDetail PaymentDetail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
