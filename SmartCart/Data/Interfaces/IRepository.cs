using System.Linq.Expressions;

namespace SmartCart.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // البحث بواسطة المعرف (ID)
        T FindById(int id);

        // البحث بناءً على تعبير مطابقة (مثل: `x => x.Name == "John"`)
        T SelectOne(Expression<Func<T, bool>> match);

        // إرجاع جميع السجلات
        IEnumerable<T> FindAll();

        // إرجاع جميع السجلات مع "تضمين" خصائص مرتبطة (Navigation Properties)
        IEnumerable<T> FindAll(params string[] includes);

        // عمليات البحث غير المتزامنة (async)
        Task<T> FindByIdAsync(int id);

        Task<IEnumerable<T>> FindAllAsync();

        Task<IEnumerable<T>> FindAllAsync(params string[] includes);

        // إضافة سجل واحد
        void AddOne(T myItem);

        // تحديث سجل واحد
        void UpdateOne(T myItem);

        // حذف سجل واحد
        void DeleteOne(T myItem);

        // إضافة مجموعة من السجلات
        void AddList(IEnumerable<T> myList);

        // تحديث مجموعة من السجلات
        void UpdateList(IEnumerable<T> myList);

        // حذف مجموعة من السجلات
        void DeleteList(IEnumerable<T> myList);
    }
}
