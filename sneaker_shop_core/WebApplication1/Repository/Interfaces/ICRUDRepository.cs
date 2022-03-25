namespace WebApplication1.Repository.Interfaces
{
    public interface ICRUDRepository<T, Y>
        where T : class
    {
        public IQueryable<T> findAll();
        public Task<T> findById(Y id);
        public Task<T> Create(T t);
        public Task<T> Update(T t);
        public Task<bool> Delete(T t);
    }
}
