using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class CartItemService : BaseService<CartItem, int>
    {
        public CartItemService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override CartItem Update(CartItem t)
        {
            var result = entitySet.Where(x => x.ProductId == t.ProductId && x.CartSessionId == t.CartSessionId).SingleOrDefault();
            if(result == null)
            {
                return null;
            }
            result = t;
            dbContext.SaveChanges();
            return result;
        }
    }
}
