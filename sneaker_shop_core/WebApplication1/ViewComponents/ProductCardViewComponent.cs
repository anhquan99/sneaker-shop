
namespace WebApplication1.ViewComponents
{
    [ViewComponent(Name = "ProductCard")]
    public class ProductCardViewComponent : ViewComponent
    {
        private readonly IProductRepository _repo;
        public ProductCardViewComponent(IProductRepository repo)
        {
            _repo = repo;
        }
        public IViewComponentResult Invoke(ProductCardViewModel data, string cardType)
        {

            if(cardType.Equals("Ranking", StringComparison.OrdinalIgnoreCase))
            {
                return View("ProductCardRanking", data);
            }
            else if(cardType.Equals("NewRelease", StringComparison.OrdinalIgnoreCase))
            {
                return View("ProductCardWithNewRelease", data);

            }
            else
            {
                return View(data);
            }
        }
    }
}
