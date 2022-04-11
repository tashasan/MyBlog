using MyBlog.Entities.Abstract;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Blog:Base
    {
        
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public int CategoryId { get; set; }
        public Category Category  { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
