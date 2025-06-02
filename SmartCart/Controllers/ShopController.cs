using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartCart.Data.Interfaces;
using SmartCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCart.Controllers
{
    public class ShopController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShopController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index(string sortOrder, int? categoryId, string searchString)
        {
            // حفظ معايير التصفية والفرز
            ViewBag.CurrentSort = sortOrder;
            ViewBag.CurrentCategoryId = categoryId;
            ViewBag.CurrentFilter = searchString;

            // جلب جميع الفئات
            var categories = await _unitOfWork.Categories.FindAllAsync();
            ViewBag.Categories = categories;

            // جلب المنتجات الأساسية
            var products = (await _unitOfWork.Products.FindAllAsync()).AsQueryable();

            // التصفية حسب الفئة
            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value);
            }

            // البحث
            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p =>
                    p.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                    p.Description.Contains(searchString, StringComparison.OrdinalIgnoreCase));
            }

            // الفرز
            products = sortOrder switch
            {
                "name_asc" => products.OrderBy(p => p.Name),
                "price_asc" => products.OrderBy(p => p.Price),
                "price_desc" => products.OrderByDescending(p => p.Price),
                _ => products.OrderBy(p => p.Id)
            };

            return View(products.ToList());
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