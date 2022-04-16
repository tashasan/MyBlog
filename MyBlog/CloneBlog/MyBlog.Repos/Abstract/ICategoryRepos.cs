using MyBlog.Core;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repos.Abstract
{
    public interface ICategoryRepos:IBaseRepository<Category>
    {
        void CategoryAdd(Category category);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetCategoryList();
        Category GetCategoryById(int id);
    }
}
