using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Interfaces.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace ApplicationUser.Controllers
{
    public class AuthController:Controller
    {
        private readonly IIdentityService _identityService;
        private readonly IConfiguration   _configuration;
        // private readonly UserManager<ApplicationUser> _userManager;

        public AuthController (IIdentityService identityService, IConfiguration configuration)
        {
            _configuration = configuration;
            _identityService = identityService;
            // _userManager = userManager;
        }


        [HttpGet]
        public IActionResult LogOut ()
        {
            HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login");
        }


    

        public IActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login (string userName, string password)
        {
            var user = _identityService.FindByName(userName);
            if (user != null)
            {
                var isValidPasssword = _identityService.CheckPassword(user, password);
                if (isValidPasssword)
                {
                    var roles = _identityService.GetRoles(user);
                    _identityService.SetClaims(user, roles);
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.Messsage = "Invalid Credentials";
                return View();
            }

            ViewBag.Message = "Invalid Credentials";
            return View();

        }
    }
}
