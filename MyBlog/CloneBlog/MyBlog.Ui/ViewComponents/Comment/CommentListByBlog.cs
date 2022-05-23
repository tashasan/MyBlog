using Microsoft.AspNetCore.Mvc;
using MyBlog.UoW;

namespace MyBlog.Ui.ViewComponents.Comment
{
    public class CommentListByBlog: ViewComponent
    {
        IUnitOfWork _uow;

        public CommentListByBlog(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IViewComponentResult Invoke(int id)
        {
            return View(_uow._commentRepos.GetCList(id));
        }
    }  
}
