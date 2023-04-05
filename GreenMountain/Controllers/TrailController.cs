using GreenMountain.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GreenMountain.Controllers
{
    public class TrailController : Controller { 

        private readonly GreenMountainContext _context;

        public TrailController(GreenMountainContext context)
        {
            _context = context;
        }
    
        // GET: /Trail/
        public IActionResult Index()
        {
            var trails = _context.Trails;
            //Console.WriteLine(_context.Trails);
            return View(trails);
        }
    }
}
