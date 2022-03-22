using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class ProductImageRepo : BaseRepo<ProductImage, int>
    {
        public ProductImageRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override Task<ProductImage> Update(ProductImage t)
        {
            throw new NotImplementedException();
        }
    }
}
