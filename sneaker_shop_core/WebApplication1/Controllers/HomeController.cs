using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _repo;
        public HomeController(ILogger<HomeController> logger, IProductRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }
        public IActionResult Index()
        {
            try
            {
                ViewBag.Title = "NASH";
                ViewBag.NewReleaseData = _repo.getByReleaseDate("all").Take(20).ToList();
                ViewBag.Trending = _repo.getTreding().Take(20).ToList();
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return RedirectToAction("", "Error", new { message = ex.Message });
            }
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
