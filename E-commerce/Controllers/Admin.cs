using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{

    [Authorize(Roles ="Admin")]

    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home() 
        {

            return View();
        }

    }
}
