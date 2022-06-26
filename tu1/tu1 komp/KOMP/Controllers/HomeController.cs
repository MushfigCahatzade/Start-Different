using Microsoft.AspNetCore.Mvc;

namespace KOMP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
