using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Create_task.Controllers
{
    public class AccountController:Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signManager;
        private RoleManager<IdentityRole> _roleManager;
        public AccountController(RoleManager<IdentityRole>
            roleManager,UserManager<AppUser>userManager,SignInManager<AppUser>
            signInManager)
        {
            _userManager = userManager;
            _signManager = signInManager;
            _roleManager = roleManager;
        }

        public async void CreateRole()
        {
            foreach (var item in Enum.GetValues(typeof(Roless)))
            {
                if (!await _roleManager.RoleExistsAsync(item.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = item.ToString() });
                }
            }
        }
    }
}
