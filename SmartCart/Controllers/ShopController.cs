using Microsoft.AspNetCore.Mvc;
using SmartCart.Data.Interfaces;

namespace SmartCart.Controllers
{
    public class ShopController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShopController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _unitOfWork.Products.FindAllAsync();
            return View(products);
        }
    }
}
