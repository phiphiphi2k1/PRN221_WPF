using Microsoft.EntityFrameworkCore;

using System.Linq;
using WPF_StudentManagement.Models;

namespace Repository
{
    public class RepositoryBase<T> where T : class
    {
        private readonly StudentMagement_FinalContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase()
        {
            _context = new StudentMagement_FinalContext();
            _dbSet = _context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            //_dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}


