using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Repository.Interfaces;

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
