using Microsoft.AspNetCore.Mvc;
using MyBlog.UoW;

namespace MyBlog.Ui.Controllers
{
    public class CategoryController : Controller
    {
        IUnitOfWork _uow;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_uow._categoryRepos.GetCategoryList());
        }
    }
}
