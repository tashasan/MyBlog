using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Core
{
    public interface IBaseRepository<T> where T : class
    {
        DbSet<T> Set();
        List<T> List();
    }
}
