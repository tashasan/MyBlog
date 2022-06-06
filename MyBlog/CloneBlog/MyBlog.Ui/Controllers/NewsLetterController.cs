using Microsoft.AspNetCore.Mvc;
using MyBlog.Entities.Concrete;
using MyBlog.UoW;

namespace MyBlog.Ui.Controllers
{
    public class NewsLetterController : Controller
    {
        IUnitOfWork _uow;


        public NewsLetterController(IUnitOfWork uow)
        {
            _uow = uow;

        }
        public PartialViewResult SubscibeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscibeMail(NewsLetter n)
        {
            return PartialView();
        }
    }
}
