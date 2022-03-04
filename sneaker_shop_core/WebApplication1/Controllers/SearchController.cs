using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SearchController : Controller
    {
        public async Task<IActionResult> Index(string type, string keyword)
        {
            return View();
        }
    }
}
