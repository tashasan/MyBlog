using Microsoft.AspNetCore.Mvc;
using MyBlog.UoW;

namespace MyBlog.Ui.Controllers
{
    public class CommentController : Controller
    {
        IUnitOfWork _uow;
        
        public CommentController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }   
        public PartialViewResult CommentListByBlog(int id)
        {
            
            return PartialView(_uow._commentRepos.GetCommentList(id));
        }
    }
}
