using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CheckoutController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
