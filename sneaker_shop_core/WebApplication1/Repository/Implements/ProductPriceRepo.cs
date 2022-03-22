using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class ProductPriceRepo : BaseRepo<ProductPrice, int>
    {
        public ProductPriceRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async override Task<ProductPrice> Update(ProductPrice t)
        {
            var result = entitySet.Where(x => x.ProductInventoryId == t.ProductInventoryId && x.EffectTime == t.EffectTime).FirstOrDefault();
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
