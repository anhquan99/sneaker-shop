namespace WebApplication1.Entities
{
    public class UserPayment
    {
        public User User { get; set; }  
        public string PaymentType { get; set; }
        public string ? Provider { get; set; }
        public string ? AccountNumber { get; set; }
        public DateOnly ? Expiry { get; set; }
    }
}
