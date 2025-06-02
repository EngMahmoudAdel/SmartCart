using Microsoft.AspNetCore.Mvc;
using SmartCart.Data.Interfaces;
using SmartCart.Models;
using System.Threading.Tasks;

namespace SmartCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Admin/Category
        public async Task<IActionResult> Index()
        {
            var categories = await _unitOfWork.Categories
                .FindAllAsync(p => true, "Products");

            return View(categories);
        }

        // GET: Admin/Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.Categories.AddOneAsync(category);
                await _unitOfWork.CompleteAsync();
                TempData["Success"] = "تم إضافة التصنيف بنجاح";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Admin/Category/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _unitOfWork.Categories.FindByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Categories.UpdateOne(category);
                await _unitOfWork.CompleteAsync();
                TempData["Success"] = "تم تحديث التصنيف بنجاح";
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Admin/Category/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _unitOfWork.Categories.FindByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _unitOfWork.Categories.FindByIdAsync(id);
            if (category != null)
            {
                _unitOfWork.Categories.DeleteOne(category);
                await _unitOfWork.CompleteAsync();
                TempData["Success"] = "تم حذف التصنيف بنجاح";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}