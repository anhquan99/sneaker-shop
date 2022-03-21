namespace WebApplication1.Infrastructure.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<Product> Page(this IQueryable<Product> source, int page, int pageSize)
        {
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
