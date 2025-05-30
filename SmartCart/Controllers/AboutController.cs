using Microsoft.AspNetCore.Mvc;

namespace SmartCart.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
