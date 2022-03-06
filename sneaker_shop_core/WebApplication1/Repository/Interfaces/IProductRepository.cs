namespace WebApplication1.Repository.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> getMostWanted();
    }
}
