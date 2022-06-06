using Microsoft.AspNetCore.Mvc;
using MyBlog.UoW;

namespace MyBlog.Ui.ViewComponents.Blog
{
    public class WriterLastBlogs:ViewComponent
    {
        IUnitOfWork _uow;

        public WriterLastBlogs(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IViewComponentResult Invoke()
        {
            return View(_uow._blogRepos.GetBlogListByWriter(1));
        }
    }
}
