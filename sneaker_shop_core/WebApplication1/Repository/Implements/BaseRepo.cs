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
            await entitySet.AddAsync(t);
            await dbContext.SaveChangesAsync();
            return t;
        }

        public async Task<bool> Delete(T t)
        {
            entitySet.Remove(t);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<T>> findAll()
        {
            return await entitySet.ToListAsync();

        }

        public async Task<T> findById(T id)
        {
            return await entitySet.FindAsync(id);
        }

        public abstract Task<T> Update(T t);
    }
}
