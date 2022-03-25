namespace WebApplication1.ViewComponents
{
    [ViewComponent(Name = "ProductList")]
    public class ProductListViewComponent : ViewComponent
    {
        
        public IViewComponentResult Invoke(ProductListViewModel data, string type = "")
        {
            if (type.Equals("Brand", StringComparison.OrdinalIgnoreCase))
            {
                return View("ProductListWithBrand", data);
            }
            return View(data);
        }
    }
}
