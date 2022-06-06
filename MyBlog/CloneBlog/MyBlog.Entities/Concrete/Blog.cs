using MyBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Blog:Base
    {
        public Blog()
        {
            Comments = new HashSet<Comment>();
        }

        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Categories  { get; set; }
        [ForeignKey("Writer")]
        public int WriterId { get; set; }
        public Writer Writers { get; set; }

        public ICollection<Comment> Comments { get; set; }
       

        

    }
}
