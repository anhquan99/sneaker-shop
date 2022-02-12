using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public class BrandSilhouetteService : BaseService<BrandSilhouette, string>
    {
        public BrandSilhouetteService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override BrandSilhouette Update(BrandSilhouette t)
        {
            var result = entitySet.Where(x => x.NameId == t.NameId).SingleOrDefault();
            if(result == null)
            {
                return null;
            }
            result = t;
            dbContext.SaveChanges();    
            return result;
        }
    }
}
