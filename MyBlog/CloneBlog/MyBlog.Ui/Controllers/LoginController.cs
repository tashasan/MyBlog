using Microsoft.AspNetCore.Mvc;
using MyBlog.UoW;

namespace MyBlog.Ui.Controllers
{
    public class LoginController : Controller
    {
        IUnitOfWork _uow;

        public LoginController(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
