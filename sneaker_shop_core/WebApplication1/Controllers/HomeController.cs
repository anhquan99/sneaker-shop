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
            ViewBag.Title = "NASH";
            var NewRelease= new List<ProductCardViewModel>();
            foreach(var i in _repo.getByReleaseDate("all").Take(20))
            {
                NewRelease.Add(new ProductCardViewModel(i));
            }
            ViewBag.NewRelease = NewRelease;
            var Trending = new List<ProductCardViewModel>();
            foreach(var i in _repo.getTreding().Take(20))
            {
                Trending.Add(new ProductCardViewModel(i));
            }
            ViewBag.Trending = Trending;
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
