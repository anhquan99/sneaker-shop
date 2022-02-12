namespace WebApplication1.Repository.Interfaces
{
    public interface ICRUDRepository<T, Y> 
        where T : class
    {
        public List<T> findAll();
        public T findById(T id);
        public T Create(T t);
        public T Update(T t);   
        public void Delete(T t);
    }
}
