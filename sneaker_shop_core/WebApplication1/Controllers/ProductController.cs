using Microsoft.AspNetCore.Mvc;
using WebApplication1.Infrastructure.Exceptions;

namespace WebApplication1.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;   
        private readonly IProductRepository _productRepo;
        public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
        {
            _logger = logger;   
            _productRepo = productRepository;
        }
        [Route("Detail/{ProductName}")]
        public async Task<IActionResult> ProductDetail([FromRoute] string ProductName)
        {
            Product product = await this._productRepo.findByName(ProductName);
            if(product == null)
            {
                throw new RecodNotFoundException(ProductName);
            }
            var result = new ProductViewModel(product);
            return View(result);
        }
        [Route("Brand/{brand}")]
        public IActionResult ListByBrand([FromRoute] string brand)
        {
            return View();
        }


    }
}
