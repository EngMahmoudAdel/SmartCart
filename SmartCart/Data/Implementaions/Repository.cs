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

        public T FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public T SelectOne(Expression<Func<T, bool>> match)
        {
            return _dbSet.FirstOrDefault(match);
        }

        public IEnumerable<T> FindAll()
        {
            return _dbSet.ToList();
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

        public async Task<T> FindByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(params string[] includes)
        {
            IQueryable<T> query = _dbSet;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.ToListAsync();
        }

        public void AddOne(T myItem)
        {
            _dbSet.Add(myItem);
        }

        public void UpdateOne(T myItem)
        {
            _dbSet.Update(myItem);
        }

        public void DeleteOne(T myItem)
        {
            _dbSet.Remove(myItem);
        }

        public void AddList(IEnumerable<T> myList)
        {
            _dbSet.AddRange(myList);
        }

        public void UpdateList(IEnumerable<T> myList)
        {
            _dbSet.UpdateRange(myList);
        }

        public void DeleteList(IEnumerable<T> myList)
        {
            _dbSet.RemoveRange(myList);
        }
    }

}
