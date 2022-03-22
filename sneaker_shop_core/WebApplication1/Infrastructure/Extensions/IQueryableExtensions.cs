using System.Linq.Expressions;
using WebApplication1.Infrastructure.Enums;

namespace WebApplication1.Infrastructure.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<Product> Page(this IQueryable<Product> source, int page, int pageSize)
        {
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
        public static Expression<Func<Product, bool>> isSneaker()
        {
            return p => p.Type == ProductTypesEnum.Sneaker.getEnumDescription();
        }
        public static Expression<Func<Product, bool>> isApparel()
        {
            return p => p.Type == ProductTypesEnum.Apparel.getEnumDescription();
        }
    }
}
