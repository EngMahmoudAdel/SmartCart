using Microsoft.AspNetCore.Mvc;

namespace SmartCart.Controllers
{
    public class ShopSingleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
