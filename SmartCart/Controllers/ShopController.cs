using Microsoft.AspNetCore.Mvc;

namespace SmartCart.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
