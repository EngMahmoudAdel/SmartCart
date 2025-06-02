using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartCart.Data.Interfaces;
using SmartCart.Models;
using System.Threading.Tasks;

namespace SmartCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Admin/Product
        public async Task<IActionResult> Index()
        {
            var products = await _unitOfWork.Products.FindAllAsync(p => true, "Category");
            return View(products);
        }

        // GET: Admin/Product/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var product = await _unitOfWork.Products.FindByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: Admin/Product/Create
        public async Task<IActionResult> Create()
        {
            await LoadCategories();
            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Product product, IFormFile imageFile)
        {
            // إزالة التحقق من الحقول التي نتعامل معها يدويًا
            ModelState.Remove("ImagePath");
            ModelState.Remove("Category");
            ModelState.Remove("CartItems");
            ModelState.Remove("OrderItems");

            if (ModelState.IsValid)
            {
                // معالجة رفع الصورة
                if (imageFile != null && imageFile.Length > 0)
                {
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img");
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    var fileName = Path.GetFileName(imageFile.FileName);
                    var filePath = Path.Combine(uploadsFolder, fileName);


                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(fileStream);
                    }

                    product.ImagePath = "/img/" + fileName;
                }

                await _unitOfWork.Products.AddOneAsync(product);
                await _unitOfWork.CompleteAsync();

                return RedirectToAction("Index");
            }

            // في حالة وجود أخطاء، إعادة تحميل الفئات
            await LoadCategories();
            return View(product);
        }


        // GET: Admin/Product/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _unitOfWork.Products.FindByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            await LoadCategories();
            return View(product);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product, IFormFile imageFile)
        {
            if (id != product.Id)
                return NotFound();

            // إزالة التحقق من الحقول التي لا نريد التحقق منها
            ModelState.Remove("ImagePath");
            ModelState.Remove("Category");
            ModelState.Remove("CartItems");
            ModelState.Remove("OrderItems");
            ModelState.Remove("imageFile"); // هذه هي الإضافة المهمة لحل المشكلة

            if (ModelState.IsValid)
            {
                try
                {
                    var existingProduct = await _unitOfWork.Products.FindByIdAsync(id);
                    if (existingProduct == null)
                    {
                        return NotFound();
                    }

                    // تحديث الخصائص الأساسية
                    existingProduct.Name = product.Name;
                    existingProduct.Description = product.Description;
                    existingProduct.Price = product.Price;
                    existingProduct.CategoryId = product.CategoryId;

                    // معالجة الصورة فقط إذا تم تحميل صورة جديدة
                    if (imageFile != null && imageFile.Length > 0)
                    {
                        // حذف الصورة القديمة إذا كانت موجودة
                        if (!string.IsNullOrEmpty(existingProduct.ImagePath))
                        {
                            var oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot",
                                existingProduct.ImagePath.TrimStart('/'));
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }

                        // رفع الصورة الجديدة
                        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img");
                        if (!Directory.Exists(uploadsFolder))
                        {
                            Directory.CreateDirectory(uploadsFolder);
                        }

                        var uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(imageFile.FileName);
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(fileStream);
                        }

                        existingProduct.ImagePath = "/img/" + uniqueFileName;
                    }

                    _unitOfWork.Products.UpdateOne(existingProduct);
                    await _unitOfWork.CompleteAsync();
                    TempData["Success"] = "تم تحديث المنتج بنجاح";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"حدث خطأ أثناء التحديث: {ex.Message}");
                }
            }
            else
            {
                // طباعة أخطاء ModelState لتصحيح المشكلة
                foreach (var key in ModelState.Keys)
                {
                    var state = ModelState[key];
                    foreach (var error in state.Errors)
                    {
                        Console.WriteLine($"Key: {key}, Error: {error.ErrorMessage}");
                    }
                }
            }

            await LoadCategories();
            return View(product);
        }


        // GET: Admin/Product/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _unitOfWork.Products.FindByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _unitOfWork.Products.FindByIdAsync(id);
            if (product != null)
            {
                // Delete associated image if it exists
                if (!string.IsNullOrEmpty(product.ImagePath))
                {
                    var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", product.ImagePath.TrimStart('/'));
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }

                _unitOfWork.Products.DeleteOne(product);
                await _unitOfWork.CompleteAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task LoadCategories()
        {
            var categories = await _unitOfWork.Categories.FindAllAsync();

            // التأكد من وجود فئات قبل عرض النموذج
            if (!categories.Any())
            {
                // يمكنك إضافة فئة افتراضية هنا إذا لزم الأمر
                throw new Exception("No categories available. Please add categories first.");
            }

            ViewBag.Categories = new SelectList(categories, "Id", "Name");
        }
    }
}