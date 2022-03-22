using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class UserShippingAddressRepo : BaseRepo<UserShippingAddress, Guid>
    {
        public UserShippingAddressRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async override Task<UserShippingAddress> Update(UserShippingAddress t)
        {
            var result = entitySet.Where(x => x.UserId == t.UserId && x.Address == t.Address).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            result = t;
            await dbContext.SaveChangesAsync();
            return result;
        }
    }
}
