namespace WebApplication1.Entities
{
    public class UserPayment
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }  
        public string PaymentType { get; set; }
        public string Provider { get; set; }
        public string AccountNumber { get; set; }
        public DateTime  Expiry { get; set; }
    }
}
