using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("Wait for hot reload");
            return View();
        }
    }
}
