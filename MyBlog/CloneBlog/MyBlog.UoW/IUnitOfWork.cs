using MyBlog.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.UoW
{
    public interface IUnitOfWork
    {
        IAboutRepos _aboutRepos { get; }
        ICategoryRepos _categoryRepos { get; }
        IBlogRepos _blogRepos { get; }
        ICommentRepos _commentRepos { get; }
        IContactRepos _contactRepos { get; }
        IWriterRepos _writerRepos { get; }  
        INewsLetterRepos _newsLetterRepos { get; }
        void Save();
    }
}
