using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class BrandSilhouetteRepo : BaseRepo<BrandSilhouette, string>
    {
        public BrandSilhouetteRepo(ApplicationDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }
        public async override Task<BrandSilhouette> Update(BrandSilhouette t)
        {
            var result = entitySet.Where(x => x.NameId == t.NameId).SingleOrDefault();
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
