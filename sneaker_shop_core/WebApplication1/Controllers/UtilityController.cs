using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UtilityController : Controller
    {
        static string path = Path.Combine(Environment.CurrentDirectory, "image");
        [Route("[controller]/{imageName}")]
        public ActionResult Index([FromRoute] string imageName)
        {
            string resultPath = Path.Combine(path, imageName);
            FileStream fs = new FileStream(resultPath, FileMode.Open);
            var result = base.File(fs, "image/jpeg");
            return result;
        }
    }
}
