using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogService
{
    class BlogObject
    {
        public BlogObject(int id, String name)
        {
            this.id = id;
            this.Name = name;
        }

        public int id { get; set; }
        public String Name { get; set; }
    }
}
