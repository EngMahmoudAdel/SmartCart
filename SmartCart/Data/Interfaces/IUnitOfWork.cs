
using SmartCart.Models;

namespace SmartCart.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {


        // تعريف الـ Repositories
        IRepository<Product> Products { get; }
        IRepository<Category> Categories { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderItem> OrderItems { get; }
        IRepository<Cart> Carts { get; }
        IRepository<CartItem> CartItems { get; }
        IRepository<ContactMessage> ContactMessages { get; }
        IRepository<Payment> Payments { get; }
        IRepository<ApplicationUser> ApplicationUsers { get; }

        // دالة لحفظ التغييرات في قاعدة البيانات
        Task<int> CompleteAsync();
    }
}