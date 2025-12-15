using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-- Lavet af Frederik --//

namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the BlogRepository class
    /// </summary>
    public interface IBlogRepository
    {
        void AddBlog(IBlog b);
        void RemoveBlog(IBlog b);
        List<IBlog> GetAllBlogs();
        void PrintAll();
        void UpdateBlog(int id, IBlog newBlog);
    }
}
