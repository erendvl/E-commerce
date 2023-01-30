using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Controllers
{
    public class Actor : Controller
    {
        private readonly DataBaseContx _data;

        public Actor(DataBaseContx data)
        {
            _data = data;
        }

        public async Task<IActionResult>Index()
        {
            var Actor = await _data.Actors.ToListAsync();
            return View(Actor);
        }
    }
}
