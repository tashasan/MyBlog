using MyBlog.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        Context _db;
        public UnitOfWork(Context db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
