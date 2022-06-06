using FluentValidation;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repos.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("en az 2 karakter");
            RuleFor(x => x.WriterLastName).NotEmpty().WithMessage("Yazar Soyadı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar eMail boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar şifresi boş geçilemez.");
        }
    }
}
