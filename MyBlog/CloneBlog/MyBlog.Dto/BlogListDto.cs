using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Dto
{
    public class BlogListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string CategoryName { get; set; }
        public string BlogImage { get; set; }
        public string Description { get; set; }
    }
}
