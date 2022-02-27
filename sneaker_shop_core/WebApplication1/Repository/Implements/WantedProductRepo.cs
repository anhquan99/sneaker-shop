using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class WantedProductRepo : BaseRepo<WantedProduct, Guid>
    {
        public WantedProductRepo(ApplicationDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }
        public override Task<WantedProduct> Update(WantedProduct t)
        {
            throw new NotImplementedException();
        }
    }
}
