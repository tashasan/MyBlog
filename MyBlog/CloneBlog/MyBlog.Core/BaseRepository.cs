using Microsoft.EntityFrameworkCore;
using MyBlog.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        Context _db;
        public BaseRepository(Context db)
        {
            _db = db;
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }

        public IQueryable<T> Get()
        {
            return Set().ToList().AsQueryable();
        }

        public void Insert(T entity)
        {
              Set().Add(entity);
        }

        public void Update(T entity)
        {
            Set().Add(entity);
        }

        public void Delete(T entity)
        {
            Set().Remove(entity);
        }

        public T GetById(int id)
        {
            return Set().Find(id);
        }

        public List<T> GetList()
        {
            return Set().ToList();
        }
    }
}
