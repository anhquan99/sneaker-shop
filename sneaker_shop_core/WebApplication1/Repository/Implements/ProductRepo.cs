using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Infrastructure.Enums;
using WebApplication1.Infrastructure.Extensions;

namespace WebApplication1.Repository.Implements
{
    public class ProductRepo : BaseRepo<Product, int>, IProductRepository
    {
        public ProductRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<Product> findAll()
        {
            return this.entitySet.OrderBy(x => x.Releasedate);
        }

        public IQueryable<Product> findByBrandSilhouette(string brand)
        {
            return entitySet
                .Where(x => x.BrandSilhouette
                .Any(y => y.NameId
                    .Equals(brand)));
        }

        public async Task<Product> findByName(string name)
        {
            return await entitySet.Include("ProductImages")
                .Include("BrandSilhouette")
                .Where(x => x.Name == name)
                .FirstOrDefaultAsync();
        }

        public IQueryable<Product> getByMostWanted()
        {
            return entitySet.OrderByDescending(x => x.WantedProducts.Count);
        }

        public IQueryable<Product> getByReleaseDate(string type)
        {
            if(type.Equals("all", StringComparison.OrdinalIgnoreCase))
            {
                return entitySet.OrderBy(x => x.Releasedate).Where(IQueryableExtensions.isSneaker());

            }
            else if(type.Equals(ProductTypesEnum.Apparel.getEnumDescription(), StringComparison.OrdinalIgnoreCase))
            {
                return entitySet.OrderBy(x => x.Releasedate).Where(IQueryableExtensions.isApparel());
            }
            else
            {
                return entitySet.OrderBy(x => x.Releasedate);
            }
        }

        public IQueryable<Product> getTreding()
        {
            return entitySet.OrderBy(x => x.Releasedate).ThenBy(x => x.WantedProducts.Count);
        }

        public async override Task<Product> Update(Product t)
        {
            var result = entitySet.Where(x => x.Id == t.Id).FirstOrDefault();
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
