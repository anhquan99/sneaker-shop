using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class ProductListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
