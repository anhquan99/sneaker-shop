using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class OrderItemRepo : BaseRepo<OrderItem, int>
    {
        public OrderItemRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async override Task<OrderItem> Update(OrderItem t)
        {
            var result = entitySet.Where(x => x.ProductId == t.ProductId && x.OrderId == t.OrderId).SingleOrDefault();
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
