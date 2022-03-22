using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICRUDRepository<Product, int> _repo;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Wait for hot reload");
            return View();
        }
        //public async Task<IActionResult> Discover()
        //{
        //    return View();
        //}
        //public async Task<IActionResult> ShopAll()
        //{
        //    return View();
        //}
        //public async Task<IActionResult> MostWanted()
        //{
        //    return View();
        //}
    }
}
