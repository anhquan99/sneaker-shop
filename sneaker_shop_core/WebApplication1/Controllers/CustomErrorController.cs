using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CustomErrorController : Controller
    {
        [Route("[controller]/{ErrorMessage}")]
        public IActionResult Index(string ErrorMessage)
        {
            return View(ErrorMessage);
        }
    }
}
