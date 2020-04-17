using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginFunctionality.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginFunctionality.Controllers
{
    public class AccountController : Controller
    {
        // readonly SignInManager<IdentityUser> signInManager;

        public AccountController()
        {
            //this.signInManager = signInManager;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Validate from Web API
                //To be implemented later.
                //var result = await signInManager.PasswordSignInAsync(model.Email,model.Password,model.RememberMe,false);

                //if (result.Succeeded)
                //{
                //    return RedirectToAction("index", "home");
                //}
                return RedirectToAction("index", "home");


                //ModelState.AddModelError(string.Empty, "Invalid login attempt");                 
            }

            return View(model);
        }
    }
}
