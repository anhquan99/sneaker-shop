using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class ProductPriceService : BaseService<ProductPrice, int>
    {
        public ProductPriceService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override ProductPrice Update(ProductPrice t)
        {
            var result = entitySet.Where(x => x.ProductInventoryId == t.ProductInventoryId && x.EffectTime == t.EffectTime).FirstOrDefault();
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
