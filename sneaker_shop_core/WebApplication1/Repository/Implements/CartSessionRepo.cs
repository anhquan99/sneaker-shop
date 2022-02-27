using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class CartSessionRepo : BaseRepo<CartSession, int>
    {
        public CartSessionRepo(ApplicationDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }

        public async override Task<CartSession> Update(CartSession t)
        {
            try
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
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return null;
            }
        }
    }
}
