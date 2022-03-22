using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class ProductInventoryRepo : BaseRepo<ProductInventory
        , int>
    {
        public ProductInventoryRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async override Task<ProductInventory> Update(ProductInventory t)
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
