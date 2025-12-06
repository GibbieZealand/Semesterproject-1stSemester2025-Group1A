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
        #region Fields
        private List<IBlog> _blogs;
        #endregion

        #region Constructors
        public BlogRepository()
        {
            _blogs = [];
        }
        #endregion

        #region Methods
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

        public void PrintAll()
        {
            foreach (IBlog b in _blogs)
            {
                Console.WriteLine(b);
            }
        }
        #endregion
    }
}
