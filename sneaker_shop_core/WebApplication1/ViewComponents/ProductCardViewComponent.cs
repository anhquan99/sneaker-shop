namespace WebApplication1.ViewComponents
{
    [ViewComponent(Name = "ProductCard")]
    public class ProductCardViewComponent : ViewComponent
    {
        private readonly ICRUDRepository<Product, int> _repo;
        public ProductCardViewComponent(ICRUDRepository<Product, int> repo)
        {
            _repo = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
