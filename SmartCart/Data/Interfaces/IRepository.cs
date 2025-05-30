using System.Linq.Expressions;

namespace SmartCart.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // === البحث ===

        // البحث بواسطة المعرف (ID)
        T FindById(int id);
        Task<T> FindByIdAsync(int id);

        // البحث بناءً على تعبير مطابقة
        T SelectOne(Expression<Func<T, bool>> match);
        Task<T> SelectOneAsync(Expression<Func<T, bool>> match);
        Task<T> SelectOneAsync(Expression<Func<T, bool>> match, params string[] includes);

        // === جلب الكل ===

        IEnumerable<T> FindAll();
        IEnumerable<T> FindAll(params string[] includes);
        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, params string[] includes);

        // === الإضافة ===

        void AddOne(T myItem);
        Task AddOneAsync(T myItem);

        void AddList(IEnumerable<T> myList);

        // === التحديث ===

        void UpdateOne(T myItem);
        void UpdateList(IEnumerable<T> myList);

        // === الحذف ===

        void DeleteOne(T myItem);
        void DeleteList(IEnumerable<T> myList);
    }
}
