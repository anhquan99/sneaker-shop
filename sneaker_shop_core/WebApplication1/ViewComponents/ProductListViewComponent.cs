namespace WebApplication1.ViewComponents
{
    [ViewComponent(Name = "ProductList")]
    public class ProductListViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {

            return View("ProductListWithBrand");
        }
    }
}
