using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class OrderItemService : BaseService<OrderItem, int>
    {
        public OrderItemService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override OrderItem Update(OrderItem t)
        {
            var result = entitySet.Where(x => x.ProductId == t.ProductId && x.OrderId == t.OrderId).SingleOrDefault();
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
