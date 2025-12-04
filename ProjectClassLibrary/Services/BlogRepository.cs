using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Services
{
    public class BlogRepository : IBlogRepository
    {
        private List<IBlog> _blogs = [];

        public void AddBlog(IBlog blog)
        {
            foreach (IBlog b in _blogs)
            {
                if (b.Id == blog.Id)
                {
                    return;
                }
            }
            _blogs.Add(blog);
        }

        public void RemoveBlog(IBlog blog)
        {
            _blogs.Remove(blog);
        }

        public List<IBlog> GetAllBlogs()
        {
            return _blogs;
        }

        public override string ToString()
        {
            return $"Blogs {_blogs}";
        }
    }
}
