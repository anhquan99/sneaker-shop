using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Repository.Implements
{
    public class ProductRepo : BaseRepo<Product, int>, IProductRepository
    {
        public ProductRepo(ApplicationDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }

        public IQueryable<Product> getByMostWanted()
        {
            try
            {
                var result = entitySet.OrderByDescending(x => x.WantedProducts.Count);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return null;
            }
        }

        public IQueryable<Product> getByReleaseDate(string type)
        {
            try
            {
                var result = entitySet.OrderBy(x => x.Releasedate);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return null;
            }
        }

        public async override Task<Product> Update(Product t)
        {
            try
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
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return null;
            }
        }
    }
}
