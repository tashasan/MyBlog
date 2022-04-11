using MyBlog.Core;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repos.Abstract
{
    public interface IBlogRepos: IBaseRepository<Blog>
    {
    }
}
