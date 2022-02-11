namespace WebApplication1.Entities
{
    public class UserShippingAddress
    {
        public Guid UserId { get; set; } 
        public virtual User User { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}