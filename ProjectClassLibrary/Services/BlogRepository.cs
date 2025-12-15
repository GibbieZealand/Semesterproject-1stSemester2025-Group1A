using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Services
{
    /// <summary>
    /// Class for Constructing and calling Blog Repository Objects using the interface
    /// </summary>
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
        /// <summary>
        /// Adds a new blog to the blog list, 
        /// if a previous blog with the same id doesn't already exist
        /// </summary>
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
        /// <summary>
        /// Removes a blog from the blog list
        /// </summary>
        public void RemoveBlog(IBlog blog)
        {
            _blogs.Remove(blog);
        }
        /// <summary>
        /// "Updates" a blog in the blog list,
        /// by replacing it with a new blog, but keeping the old id
        /// </summary>
        public void UpdateBlog(int id, IBlog newBlog)
        {
            for (int i = 0; i < _blogs.Count; i++)
            {
                if (_blogs[i].Id == id)
                {
                    newBlog.Id = id;
                    _blogs[i] = newBlog;
                    return;
                }
            }
        }
        /// <summary>
        /// Returns our blog list
        /// </summary>
        public List<IBlog> GetAllBlogs()
        {
            return _blogs;
        }
        /// <summary>
        /// Prints all blogs in the blog list
        /// </summary>
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
