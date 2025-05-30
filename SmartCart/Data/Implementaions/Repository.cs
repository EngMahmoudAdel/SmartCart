using Microsoft.EntityFrameworkCore;
using SmartCart.Data.Interfaces;
using System.Linq.Expressions;

namespace SmartCart.Data.Implementaions
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        //=== البحث ===

        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public T SelectOne(Expression<Func<T, bool>> match)
        {
            return _dbSet.FirstOrDefault(match);
        }

        public async Task<T> SelectOneAsync(Expression<Func<T, bool>> match)
        {
            return await _dbSet.FirstOrDefaultAsync(match);
        }

        public async Task<T> SelectOneAsync(Expression<Func<T, bool>> match, params string[] includes)
        {
            IQueryable<T> query = _dbSet;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.FirstOrDefaultAsync(match);
        }

        //=== إحضار الكل ===

        public IEnumerable<T> FindAll()
        {
            return _dbSet.ToList();
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public IEnumerable<T> FindAll(params string[] includes)
        {
            IQueryable<T> query = _dbSet;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return query.ToList();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, params string[] includes)
        {
            IQueryable<T> query = _dbSet;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            query = query.Where(predicate);

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        //=== الإضافة ===

        public void AddOne(T myItem)
        {
            _dbSet.Add(myItem);
        }
        public async Task AddOneAsync(T myItem)
        {
            await _dbSet.AddAsync(myItem);
        }

        public void AddList(IEnumerable<T> myList)
        {
            _dbSet.AddRange(myList);
        }

        //=== التحديث ===

        public void UpdateOne(T myItem)
        {
            _dbSet.Update(myItem);
        }

        public void UpdateList(IEnumerable<T> myList)
        {
            _dbSet.UpdateRange(myList);
        }

        //=== الحذف ===

        public void DeleteOne(T myItem)
        {
            _dbSet.Remove(myItem);
        }

        public void DeleteList(IEnumerable<T> myList)
        {
            _dbSet.RemoveRange(myList);
        }
    }
}
