using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Controllers
{
    public class Cinema : Controller
    {
        private readonly DataBaseContx _data;

        public Cinema(DataBaseContx data)
        {
            _data = data;
        }
        public async Task<IActionResult> Index()
        {
            var Cinema = await _data.Cinema.ToListAsync();
            return View(Cinema);
        }
    }
}
