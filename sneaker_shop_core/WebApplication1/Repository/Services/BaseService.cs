using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Services
{
    public abstract class BaseService<T, Y> : ICRUDRepository<T, Y> where T : class 
    {
        protected readonly ApplicationDbContext dbContext;
        protected DbSet<T> entitySet;

        public BaseService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            entitySet = dbContext.Set<T>();
        }

        public T Create(T t)
        {
            entitySet.Add(t);
            dbContext.SaveChanges();    
            return t;
        }

        public void Delete(T t)
        {
            entitySet.Remove(t);
            dbContext.SaveChanges();
        }

        public List<T> findAll()
        {
            return entitySet.ToList();
        }

        public T findById(T id)
        {
            var result = entitySet.Find(id);
            return result;
        }

        public abstract T Update(T t);
    }
}