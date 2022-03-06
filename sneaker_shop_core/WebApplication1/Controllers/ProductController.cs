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
        public async Task<IActionResult> ProductDetail(string ProductName)
        {
            return View();
        }
        public async Task<IActionResult> List(string type)
        {
            return View();
        }


    }
}
