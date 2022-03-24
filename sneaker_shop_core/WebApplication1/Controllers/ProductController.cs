using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;    
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;   
        }
        [Route("Detail/{ProductName}")]
        public IActionResult ProductDetail([FromRoute] string ProductName)
        {
            return View();
        }
        [Route("Brand/{brand}")]
        public IActionResult ListByBrand([FromRoute] string brand)
        {
            return View();
        }


    }
}
