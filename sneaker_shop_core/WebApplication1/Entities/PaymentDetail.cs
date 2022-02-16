namespace WebApplication1.Entities
{
    public class PaymentDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }    
        public int Amount { get; set; }
        public string Method { get; set; }
        public string AccountNumber { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
