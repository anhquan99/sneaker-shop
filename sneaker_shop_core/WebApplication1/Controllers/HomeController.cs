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
            var Trending = new List<ProductCardRankingViewModel>();
            int index = 1;
            foreach (var i in _repo.getTreding().Take(20))
            {
                Trending.Add(new ProductCardRankingViewModel( i, index++));
            }
            ViewBag.Trending = Trending;
            return View();
        }
    }
}
