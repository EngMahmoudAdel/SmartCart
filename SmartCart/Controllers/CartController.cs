using Microsoft.AspNetCore.Mvc;
using SmartCart.Data.Interfaces;
using SmartCart.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace SmartCart.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        private string GetCurrentUserId()
        {
            return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login", "Account");

            // التحقق من وجود المنتج
            var product = await _unitOfWork.Products.FindByIdAsync(productId);
            if (product == null)
                return NotFound("Product not found");

            // الحصول على سلة المستخدم أو إنشاء جديدة
            var cart = await _unitOfWork.Carts.SelectOneAsync(c => c.UserId == userId);
            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                await _unitOfWork.Carts.AddOneAsync(cart);
                await _unitOfWork.CompleteAsync();
            }

            // التحقق من وجود المنتج في السلة
            var existingItem = await _unitOfWork.CartItems.SelectOneAsync(ci =>
                ci.CartId == cart.Id && ci.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                _unitOfWork.CartItems.UpdateOne(existingItem);
            }
            else
            {
                var newItem = new CartItem
                {
                    CartId = cart.Id,
                    ProductId = productId,
                    Quantity = quantity
                };
                await _unitOfWork.CartItems.AddOneAsync(newItem);
            }

            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login", "Account");

            var cart = await _unitOfWork.Carts.SelectOneAsync(
                c => c.UserId == userId,
                "CartItems.Product");

            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                await _unitOfWork.Carts.AddOneAsync(cart);
                await _unitOfWork.CompleteAsync();
            }

            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuantity(int cartItemId, int quantity)
        {
            if (quantity <= 0)
                return BadRequest("Quantity must be greater than zero");

            var cartItem = await _unitOfWork.CartItems.FindByIdAsync(cartItemId);
            if (cartItem == null)
                return NotFound("Cart item not found");

            cartItem.Quantity = quantity;
            _unitOfWork.CartItems.UpdateOne(cartItem);
            await _unitOfWork.CompleteAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int cartItemId)
        {
            var cartItem = await _unitOfWork.CartItems.FindByIdAsync(cartItemId);
            if (cartItem == null)
                return NotFound("Cart item not found");

            _unitOfWork.CartItems.DeleteOne(cartItem);
            await _unitOfWork.CompleteAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> ClearCart()
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Login", "Account");

            var cart = await _unitOfWork.Carts.SelectOneAsync(c => c.UserId == userId);
            if (cart == null)
                return NotFound("Cart not found");

            var cartItems = await _unitOfWork.CartItems.FindAllAsync(ci => ci.CartId == cart.Id);
            _unitOfWork.CartItems.DeleteList(cartItems);
            await _unitOfWork.CompleteAsync();

            return RedirectToAction("Index");
        }
    }
}