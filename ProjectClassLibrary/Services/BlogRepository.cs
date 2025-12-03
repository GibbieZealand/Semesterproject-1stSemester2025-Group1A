using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Services
{
    public class BlogRepository : IBlogRepository
    {
        private List<IBlog> _blogs;

        public void AddBlog(IBlog b)
        {
            _blogs.Add(b);
        }

        public override string ToString()
        {
            return "";
        }
    }
}
