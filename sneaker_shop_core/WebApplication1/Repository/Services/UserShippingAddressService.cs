using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class UserShippingAddressService : BaseService<UserShippingAddress, Guid>
    {
        public UserShippingAddressService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override UserShippingAddress Update(UserShippingAddress t)
        {
            var result = entitySet.Where(x => x.UserId == t.UserId && x.Address == t.Address).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            result = t;
            return result;
        }
    }
}
