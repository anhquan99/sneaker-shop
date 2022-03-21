namespace WebApplication1.Repository.Interfaces
{
    public interface IProductRepository : ICRUDRepository<Product, int>
    {
        public Task<IQueryable<Product>> getByReleaseDate(string type);
    }
}
