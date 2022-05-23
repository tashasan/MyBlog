using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Core
{
    public interface IBaseRepository<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetList();
        DbSet<T> Set();
        IQueryable<T> Get();

        List<T> GetList(Expression<Func<T, bool>> filter);
    }
}
