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
    public class BlogRepos : BaseRepository<Blog>, IBlogRepos
    {
        public BlogRepos(BlogContext db) : base(db)
        {

        }

        public List<BlogListDto> GetBlogDetailList(int id)
        {
            return Set().Select(x => new BlogListDto
            {
                Id = x.Id,
                Title = x.BlogTitle,
                Date = x.Date,
                CategoryName = x.Categories.CategoryName,
                BlogImage = x.BlogImage,
                Description = x.BlogContent,
                CategoryId = x.CategoryId,
                CommentList = x.Comments.Select(a => new CommentListDto
                {
                    Id = a.Id,
                    BlogId = a.BlogId,
                    CommentContent = a.CommentContent,
                    CommentTitle = a.CommentTitle

                }).ToList(),
                

            }).Where(x => x.Id == id).ToList();
        }

        public List<BlogListDto> GetBlogList()
        {
            return Set().Select(x => new BlogListDto
            {
                Id = x.Id,
                Title = x.BlogTitle,
                Date = x.Date,
                CategoryName = x.Categories.CategoryName,
                BlogImage = x.BlogImage,
                Description = x.BlogContent,



            }).ToList();
        }
    }
}
