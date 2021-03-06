using MyBlog.Core;
using MyBlog.Dto;
using MyBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repos.Abstract
{
    public interface ICommentRepos:IBaseRepository<Comment>
    {
        List<CommentListDto> GetCommentList(int id);
        List<Comment> GetCList(int id);


    }
}
