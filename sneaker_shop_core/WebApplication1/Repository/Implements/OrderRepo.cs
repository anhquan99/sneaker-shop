using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class OrderRepo : BaseRepo<Order, int>
    {
        public OrderRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<Order> Update(Order t)
        {
            var result = entitySet.Where(x => x.Id == t.Id).SingleOrDefault();
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
