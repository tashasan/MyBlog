using Microsoft.AspNetCore.Mvc;
using MyBlog.UoW;

namespace MyBlog.Ui.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        IUnitOfWork _uow;

        public CategoryList(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IViewComponentResult Invoke()
        {
            return View(_uow._categoryRepos.GetCategoryList());
        }
    }
} 
