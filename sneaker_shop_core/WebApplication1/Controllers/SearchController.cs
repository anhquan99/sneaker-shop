using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(string type, string keyword)
        {
            return View();
        }
    }
}
