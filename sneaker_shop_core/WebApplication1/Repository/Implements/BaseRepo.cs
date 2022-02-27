using Microsoft.EntityFrameworkCore;
using WebApplication1.Repository.Interfaces;
using WebApplication1.Data;

namespace WebApplication1.Repository.Implements
{
    public abstract class BaseRepo<T, Y> : ICRUDRepository<T, Y> where T : class
    {

        protected readonly ApplicationDbContext dbContext;
        protected DbSet<T> entitySet;
        protected readonly ILogger _logger;
        public BaseRepo(ApplicationDbContext dbContext, ILogger logger)
        {
            this.dbContext = dbContext;
            entitySet = dbContext.Set<T>();
            this._logger = logger;  
        }

        public async Task<T> Create(T t)
        {
            try
            {
                await entitySet.AddAsync(t);
                await dbContext.SaveChangesAsync();
                return t;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return null;
            }
        }

        public async Task<bool> Delete(T t)
        {
            try
            {
                entitySet.Remove(t);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return false;
            }
        }

        public async Task<List<T>> findAll()
        {
            try
            {
                return await entitySet.ToListAsync();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return null;
            }
        }

        public async Task<T> findById(T id)
        {
            try
            {
                return await entitySet.FindAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return null;
            }

        }

        public abstract Task<T> Update(T t);
    }
}
