namespace WebApplication1.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepo;
        private readonly ICRUDRepository<BrandSilhouette, string> _brandSilhouetteRepo;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepo, ICRUDRepository<BrandSilhouette, string> brandSilhouetteRepo)
        {
            _logger = logger;
            _productRepo = productRepo;
            _brandSilhouetteRepo = brandSilhouetteRepo;

        }
        public IActionResult Index()
        {
            ViewBag.Title = "NASH";
            var NewRelease= new List<ProductCardViewModel>();
            foreach(var i in _productRepo.getByReleaseDate("all").Take(20))
            {
                NewRelease.Add(new ProductCardViewModel(i));
            }
            ViewBag.NewRelease = NewRelease;
            var Trending = new List<ProductCardRankingViewModel>();
            int index = 1;
            foreach (var i in _productRepo.getTreding().Take(20))
            {
                Trending.Add(new ProductCardRankingViewModel( i, index++));
            }
            ViewBag.Trending = Trending;
            return View();
        }
        [Route("ShopAll")]
        public IActionResult ShopAll()
        {
            var productList = new List<ProductCardViewModel>();
            int NumberOfRecords = _productRepo.findAll().Count();
            foreach (var i in IQueryableExtensions.Page(_productRepo.findAll(), 1, 8).ToList())
            {
                productList.Add(new ProductCardViewModel(i));
            }
            string title = "Shop All";
            var data = new ProductListViewModel(productList, title, null, NumberOfRecords, null);
            return ViewComponent("ProductList", new {data = data });
        }
        [Route("Discover")]
        public IActionResult Discover()
        {
            var productList = new List<ProductCardViewModel>();
            int NumberOfRecords = _productRepo.findAll().Count();
            foreach (var i in IQueryableExtensions.Page(_productRepo.getByMostWanted(), 1, 8).ToList())
            {
                productList.Add(new ProductCardViewModel(i));
            }
            string title = "Discover";
            var data = new ProductListViewModel(productList, title, null, NumberOfRecords, null);
            return ViewComponent("ProductList", new { data = data });
        }
        [Route("Brand/{brandName}")]
        public async Task<IActionResult> ListByBrand([FromRoute] string brandName)
        {
            var brand = await _brandSilhouetteRepo.findById(brandName);
            if (brand == null)
            {
                throw new RecodNotFoundException(brandName);
            }

            var productList = new List<ProductCardViewModel>();
            var temp = _productRepo.findByBrandSilhouette(brandName);
            int NumberOfRecords = _productRepo.findByBrandSilhouette(brandName).Count();
            foreach (var i in IQueryableExtensions.Page(_productRepo.findByBrandSilhouette(brandName), 1, 8).ToList())
            {
                productList.Add(new ProductCardViewModel(i));
            }
            string title = brand.NameId;
            string description = brand.Story;
            string icon = brand.Icon;
            var data = new ProductListViewModel(productList, title, description, NumberOfRecords, icon);
            return ViewComponent("ProductList", new { data = data, type = "Brand" });
        }
    }
}
