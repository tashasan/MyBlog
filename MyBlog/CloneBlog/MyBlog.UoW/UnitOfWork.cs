using MyBlog.Dal;
using MyBlog.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        BlogContext _db;
    

        public IAboutRepos _aboutRepos { get; private set; }

        public ICategoryRepos _categoryRepos { get; private set; }

        public IBlogRepos _blogRepos { get; private set; }

        public ICommentRepos _commentRepos { get; private set; }

        public IContactRepos _contactRepos { get; private set; }

        public IWriterRepos _writerRepos { get; private set; }

        public INewsLetterRepos _newsLetterRepos { get; private set; }

        public UnitOfWork(BlogContext db,IAboutRepos aboutRepos, IBlogRepos blogRepos, ICategoryRepos categoryRepos, ICommentRepos commentRepos, IContactRepos contactRepos, IWriterRepos writerRepos, INewsLetterRepos newsLetterRepos)
        {
            _db = db;
            _aboutRepos = aboutRepos;
            _blogRepos = blogRepos;
            _categoryRepos = categoryRepos;
            _commentRepos = commentRepos;
            _contactRepos = contactRepos;
            _writerRepos = writerRepos;
            _newsLetterRepos = newsLetterRepos;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
