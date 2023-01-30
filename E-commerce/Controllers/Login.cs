using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using E_commerce.Models;
using E_commerce.Data;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Controllers
{
    
       

        public class Login : Controller
    {



        public IActionResult LogIn()
        {
            ClaimsPrincipal user = HttpContext.User;

            if (user.Identity.IsAuthenticated ) 
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> LogIn(VMLogin modelLogin)
        {
           if(modelLogin.Email=="1@gmail.com" &&
                 modelLogin.Password == "1") 
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim("Position","Admin"),
                   
                };
               ClaimsIdentity claimsIdentity=new ClaimsIdentity(claims,
                   CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };
               await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                   new ClaimsPrincipal(claimsIdentity),properties);

                return RedirectToAction("Home", "Admin");
            }


            ViewData["Validate mesage"] = "User not found!";
           return View(modelLogin);
        }
    }
}
