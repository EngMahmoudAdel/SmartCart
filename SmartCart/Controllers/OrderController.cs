using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartCart.Models;
using SmartCart.Models.ViewModels;
using System.Security.Claims;

namespace SmartCart.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new CheckoutViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Get current user
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            // Get user's cart items with product information
            var cartItems = await _context.CartItems
              .Include(c => c.Product)
              .Include(c => c.Cart) // مهم حتى تصل إلى UserId
              .Where(c => c.Cart.UserId == userId)
              .ToListAsync();


            if (!cartItems.Any())
            {
                ModelState.AddModelError("", "Your cart is empty");
                return View(model);
            }

            // Calculate total amount
            var totalAmount = cartItems.Sum(item => item.Quantity * item.Product.Price);

            // Create order
            var order = new Order
            {
                UserId = userId,
                Address = model.Address,
                Phone = model.Phone,
                TotalAmount = totalAmount,
                OrderDate = DateTime.Now,
                OrderItems = cartItems.Select(item => new OrderItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = item.Product.Price
                }).ToList()
            };

            // Create payment
            var payment = new Payment
            {
                Order = order,
                Method = "Cash On Delivery",
                Status = "Pending",
                Amount = totalAmount,
                Date = DateTime.Now
            };

            // Save to database
            _context.Orders.Add(order);
            _context.Payments.Add(payment);

            // Clear cart
            _context.CartItems.RemoveRange(cartItems);

            await _context.SaveChangesAsync();

            return RedirectToAction("OrderConfirmation", new { orderId = order.Id });
        }

        public IActionResult OrderConfirmation(int orderId)
        {
            var order = _context.Orders
                .Include(o => o.Payment)
                .FirstOrDefault(o => o.Id == orderId);

            if (order == null || order.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return NotFound();
            }

            return View(order);
        }


        public IActionResult Details(int id)
        {
            // جلب الأوردر مع العناصر والبايمنت
            var order = _context.Orders
                         .Include(o => o.OrderItems)
                         .ThenInclude(oi => oi.Product) 
                         .Include(o => o.Payment)
                         .FirstOrDefault(o => o.Id == id);

            // تحقق من وجود الأوردر وأنه يخص المستخدم الحالي
            if (order == null || order.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
            {
                return NotFound();
            }

            return View(order);
        }


    }
}