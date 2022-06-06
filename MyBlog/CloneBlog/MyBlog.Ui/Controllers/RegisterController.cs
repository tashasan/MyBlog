using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Entities.Concrete;
using MyBlog.Repos.ValidationRules;
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
            WriterValidator wV = new WriterValidator();
            ValidationResult results = wV.Validate(writer);
            if (results.IsValid)
            {
                writer.Status = true;
                writer.WriterAbout = "Test";
                writer.CreateDate = DateTime.Now;
                writer.Date = DateTime.Now;
                writer.WriterImage = "hasan";

                _uow._writerRepos.Insert(writer);
                _uow.Save();
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

    }
}
