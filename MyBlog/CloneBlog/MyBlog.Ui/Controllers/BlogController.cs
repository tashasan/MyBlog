using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Ui.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
