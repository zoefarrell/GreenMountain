using Microsoft.AspNetCore.Mvc;

namespace GreenMountain.Controllers
{
    public class TrailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
