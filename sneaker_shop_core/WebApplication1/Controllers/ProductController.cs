using Microsoft.AspNetCore.Mvc;
using WebApplication1.Infrastructure.Exceptions;
using WebApplication1.Infrastructure.Extensions;

namespace WebApplication1.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepo;
        public ProductController(IProductRepository productRepository)
        {
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
        


    }
}
