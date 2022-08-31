using Microsoft.AspNetCore.Mvc;

namespace net200.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View("~/Views/Home/Index.cshtml");
            return View();
        }
    }
}
