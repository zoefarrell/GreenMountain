using Microsoft.AspNetCore.Mvc;

namespace GreenMountain.Controllers
{
    public class TrailController : Controller
    {
        // GET: /Trail/
        public IActionResult Index()
        {
            return View();
        }
    }
}
