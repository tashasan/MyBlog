using MyBlog.Core;
using MyBlog.Dal;
using MyBlog.Dto;
using MyBlog.Entities.Concrete;
using MyBlog.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repos.Concrete
{
    public class CommentRepos:BaseRepository<Comment>,ICommentRepos
    {
        public CommentRepos(BlogContext db) :base (db)
        {

        }

   

        public List<CommentListDto> GetCommentList(int id)
        {
            return Set().Select(x => new CommentListDto
            {
                Id = x.Id,
                CommentContent = x.CommentContent,
                CommentTitle = x.CommentTitle,
                CommentUserName = x.CommentUserName,
                BlogId = x.BlogId,

            }).Where(x => x.Id == id).ToList();

        }
        public List<Comment> GetCList(int id)
        {
            return GetList(x => x.Blog.Id == id);
        }
        
    }
}
