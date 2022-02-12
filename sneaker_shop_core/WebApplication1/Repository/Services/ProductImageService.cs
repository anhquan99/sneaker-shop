using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class ProductImageService : BaseService<ProductImage, int>
    {
        public ProductImageService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override ProductImage Update(ProductImage t)
        {
            throw new NotImplementedException();
        }
    }
}
