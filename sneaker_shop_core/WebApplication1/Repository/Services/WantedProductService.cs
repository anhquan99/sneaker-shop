using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class WantedProductService : BaseService<WantedProduct, Guid>
    {
        public WantedProductService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override WantedProduct Update(WantedProduct t)
        {
            throw new NotImplementedException();
        }
    }
}
