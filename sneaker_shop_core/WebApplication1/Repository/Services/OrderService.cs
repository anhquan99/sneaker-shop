using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class OrderService : BaseService<Order, int>
    {
        public OrderService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override Order Update(Order t)
        {
            var result = entitySet.Where(x => x.Id == t.Id).SingleOrDefault();
            if (result == null)
            {
                return null;
            }
            result = t;
            dbContext.SaveChanges();
            return result;
        }
    }
}
