global using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.ViewComponents
{
    [ViewComponent(Name = "BrandList")]
    public class BrandListViewComponent : ViewComponent
    {
        private readonly ICRUDRepository<BrandSilhouette, string> _repo;
        public BrandListViewComponent(ICRUDRepository<BrandSilhouette, string> repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<BrandSilhouette> data = _repo.findAll().ToList();
            return View(data);
        }
    }
}
