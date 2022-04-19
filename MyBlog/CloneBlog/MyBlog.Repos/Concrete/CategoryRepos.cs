using MyBlog.Core;
using MyBlog.Dal;
using MyBlog.Dto;
using MyBlog.Entities.Concrete;
using MyBlog.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repos.Concrete
{
    public class CategoryRepos:BaseRepository<Category>,ICategoryRepos
    {
        
        public CategoryRepos(Context db):base(db)
        {
            
        }

        public void CategoryAdd(Category category)
        {
            Set().Add(category);
        }

        public void CategoryDelete(Category category)
        {
            
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryListDto> GetCategoryList()
        {
            return Set().Select(x => new CategoryListDto
            {
                Id = x.Id,
                CategoryName = x.CategoryName,
                CategoryDescription = x.CategoryDescription,
                

            }).ToList();
        }
    }
}
