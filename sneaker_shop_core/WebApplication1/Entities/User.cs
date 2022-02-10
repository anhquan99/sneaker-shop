using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Entities
{
    public class User : IdentityUser<Guid>
    {
        public List<Order> orders { get; set; } 
        public List<CardSession> sessions { get; set; }
        public List<UserPayment> userPayments { get; set; }
        public List<UserShippingAddress> shippingAddresses { get; set; }
    }
}
