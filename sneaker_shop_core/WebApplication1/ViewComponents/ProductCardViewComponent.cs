
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
        public IViewComponentResult Invoke(object data, string cardType = "")
        {
            if(data.GetType().Equals(typeof(ProductCardViewModel)) || data.GetType().Equals(typeof(ProductCardRankingViewModel)))
            {
                if (cardType.Equals("ranking", StringComparison.OrdinalIgnoreCase))
                {
                    return View("ProductCardWithRanking", data);
                }
                if (cardType.Equals("NewRelease", StringComparison.OrdinalIgnoreCase))
                {
                    return View("ProductCardWithNewRelease", data);
                }
                else
                {
                    return View(data);
                }
            }
            else
            {
                throw new Exception("Class unrecognized");
            }

        }
    }
}
