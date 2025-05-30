using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartCart.Data.Interfaces;
using SmartCart.Models;

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

        [Authorize]
        public async Task<IActionResult> SingleShop(int id)
        {
           
            var product = await _unitOfWork.Products.FindByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var relatedProducts = await _unitOfWork.Products.FindAllAsync(
                p => p.CategoryId == product.CategoryId && p.Id != id);

            var viewModel = new ProductDetailViewModel
            {
                Product = product,
                RelatedProducts = relatedProducts.Take(4).ToList()
            };

            return View(viewModel);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }


    }
}
