using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Entities
{
    public class User : IdentityUser<Guid>
    {
        public virtual List<Order> orders { get; set; } 
        public virtual List<CartSession> sessions { get; set; }
        public virtual List<UserPayment> userPayments { get; set; }
        public virtual List<UserShippingAddress> shippingAddresses { get; set; }
        public virtual CartSession CartSession { get; set; }
        public virtual List<WantedProduct>  WantedProducts { get; set; }
    }
}
