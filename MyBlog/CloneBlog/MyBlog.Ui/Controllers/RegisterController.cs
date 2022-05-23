using Microsoft.AspNetCore.Mvc;
using MyBlog.Entities.Concrete;
using MyBlog.UoW;

namespace MyBlog.Ui.Controllers
{
    public class RegisterController : Controller
    {
        IUnitOfWork _uow;

        public RegisterController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            return View();
        }

    }
}
