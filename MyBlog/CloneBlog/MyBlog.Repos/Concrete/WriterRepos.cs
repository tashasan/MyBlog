using MyBlog.Core;
using MyBlog.Dal;
using MyBlog.Entities.Concrete;
using MyBlog.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repos.Concrete
{
    public class WriterRepos:BaseRepository<Writer>,IWriterRepos
    {
        public WriterRepos(BlogContext db): base(db)
        {

        }
    }
}
