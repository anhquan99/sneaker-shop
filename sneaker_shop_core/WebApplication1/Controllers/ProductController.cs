using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("/Product")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;    
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;   
        }
        [Route("Detail/{ProductName}")]
        public IActionResult ProductDetail(string ProductName)
        {
            _logger.LogWarning(0, "ProductName: " + ProductName);
            return View();
        }

    }
}
