using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogService
{
    class BlogResponse
    {
        public List<BlogObject> Blogs { get; set; }
        public bool Success { get; set; }
    }
}
