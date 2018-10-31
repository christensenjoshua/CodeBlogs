using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogs.Entities
{
    public class BlogComment
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int CommentId { get; set; }
    }
}
