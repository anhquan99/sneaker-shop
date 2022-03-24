namespace WebApplication1.Repository.Interfaces
{
    public interface IProductRepository : ICRUDRepository<Product, int>
    {
        public IQueryable<Product> getByReleaseDate(string type);
        public IQueryable<Product> getByMostWanted();
        public IQueryable<Product> getTreding();
        public Task<Product> findByName(string name);
    }
}
