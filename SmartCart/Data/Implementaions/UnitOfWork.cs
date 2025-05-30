using SmartCart.Data.Interfaces;
using SmartCart.Models;
using System;
namespace SmartCart.Data.Implementaions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        // تعريف التخزين المؤقت للـ Repositories
        private IRepository<Product> _products;
        private IRepository<Category> _categories;
        private IRepository<Order> _orders;
        private IRepository<OrderItem> _orderItems;
        private IRepository<Cart> _carts;
        private IRepository<CartItem> _cartItems;
        private IRepository<ContactMessage> _contactMessages;
        private IRepository<Payment> _payments;
        private IRepository<ApplicationUser> _applicationUsers;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        // تعريف الـ Repositories مع التخزين المؤقت
        public IRepository<Product> Products => _products ??= new Repository<Product>(_context);
        public IRepository<Category> Categories => _categories ??= new Repository<Category>(_context);
        public IRepository<Order> Orders => _orders ??= new Repository<Order>(_context);
        public IRepository<OrderItem> OrderItems => _orderItems ??= new Repository<OrderItem>(_context);
        public IRepository<Cart> Carts => _carts ??= new Repository<Cart>(_context);
        public IRepository<CartItem> CartItems => _cartItems ??= new Repository<CartItem>(_context);
        public IRepository<ContactMessage> ContactMessages => _contactMessages ??= new Repository<ContactMessage>(_context);
        public IRepository<Payment> Payments => _payments ??= new Repository<Payment>(_context);
        public IRepository<ApplicationUser> ApplicationUsers => _applicationUsers ??= new Repository<ApplicationUser>(_context);

        // دالة لحفظ التغييرات في قاعدة البيانات



        public async Task<int> CompleteAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();  // حفظ التغييرات في قاعدة البيانات
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ في الـ Console أو في ملف لوج
                Console.WriteLine($"Error saving changes: {ex.Message}");
                throw;  // إعادة رفع الاستثناء بعد تسجيله
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}