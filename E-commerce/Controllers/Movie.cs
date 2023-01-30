using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Controllers
{
    public class Movie : Controller

    {
        private readonly DataBaseContx _data;

        public Movie(DataBaseContx data)
        {
            _data = data;
        }
        public async Task<IActionResult> Index()
        {
            var Movie = await _data.Movie.ToListAsync();
            return View(Movie);
        }
    }
}
