using E_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Controllers
{
    public class Producer : Controller
    {
        private readonly DataBaseContx _data;

        public Producer(DataBaseContx data)
        {
            _data = data;
        }
        public IActionResult Index()
        {
            var Producers = _data.Producer.ToListAsync();
            return View(Producers);
        }
    }
}
