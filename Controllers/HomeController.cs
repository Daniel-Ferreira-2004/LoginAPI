using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
