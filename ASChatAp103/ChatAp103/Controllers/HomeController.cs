using ChatAp103.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAp103.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private SignInManager<AppUser> signInManager;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Chat()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> LoginAsync(LoginVm login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser dbUser=_userManager.FindByNameAsync(login.UserName).Result;
            if (dbUser==null)
            {
                ModelState.AddModelError("", "username or pasword is not valid");
            }
            Microsoft.AspNetCore.Identity.SignInResult result = _signInManager.PasswordSignInAsync(dbUser, login.Password, true, true).Result;
            if (result.Succeeded)
            {
                ModelState.AddModelError("", "username or pasword is not valid");
            }
            await  _signInManager.SignInAsync(dbUser, true);
            return RedirectToAction("chat", "home");
        }
        public ContentResult Register()
        {
            AppUser user1 = new AppUser { UserName = "_mushfig", Fullname = "Mushfig" };
            AppUser user2 = new AppUser { UserName = "_niyaz", Fullname = "Niyaz" };
            AppUser user3 = new AppUser { UserName = "_elchin", Fullname = "Elchin" };
            AppUser user4 = new AppUser { UserName = "_gunel", Fullname = "Gunel" };
            var result1 = _userManager.CreateAsync(user1, "user@123)").Result;
            var result2 = _userManager.CreateAsync(user2, "user@123)").Result;
            var result3 = _userManager.CreateAsync(user3, "user@123)").Result;
            var result4 = _userManager.CreateAsync(user4, "user@123)").Result;

            return Content("user created");
        }
    }
}
