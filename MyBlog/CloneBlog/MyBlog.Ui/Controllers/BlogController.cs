using Microsoft.AspNetCore.Mvc;

using MyBlog.UoW;

namespace MyBlog.Ui.Controllers
{
    public class BlogController : Controller
    {
        IUnitOfWork _uow;
        

        public BlogController(IUnitOfWork uow)
        {
            _uow = uow;
           
        }

        public IActionResult Index()
        {
            return View(_uow._blogRepos.GetBlogList());
        }
        public IActionResult BlogReadMore(int id)
        {
            ViewBag.Id = id;
            var res = _uow._blogRepos.GetBlogDetailList(id);
            return View(res);
            
        }
    }
}
