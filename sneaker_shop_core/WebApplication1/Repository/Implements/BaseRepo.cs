using Microsoft.EntityFrameworkCore;
using WebApplication1.Repository.Interfaces;
using WebApplication1.Data;

namespace WebApplication1.Repository.Implements
{
    public abstract class BaseRepo<T, Y> : ICRUDRepository<T, Y> where T : class
    {

        protected readonly ApplicationDbContext dbContext;
        protected DbSet<T> entitySet;
        public BaseRepo(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            entitySet = dbContext.Set<T>();
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

        public virtual IQueryable<T> findAll()
        {
            return entitySet;
        }

        public async Task<T> findById(Y id)
        {
            return await entitySet.FindAsync(id);
        }

        public abstract Task<T> Update(T t);
    }
}
