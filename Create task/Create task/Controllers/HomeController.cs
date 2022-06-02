using Microsoft.AspNetCore.Mvc;

namespace Create_task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
