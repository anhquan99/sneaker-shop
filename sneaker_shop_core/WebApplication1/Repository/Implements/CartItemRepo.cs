using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class CartItemRepo : BaseRepo<CartItem, int>
    {
        public CartItemRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<CartItem> Update(CartItem t)
        {
            var result = entitySet.Where(x => x.ProductId == t.ProductId && x.CartSessionId == t.CartSessionId).SingleOrDefault();
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
