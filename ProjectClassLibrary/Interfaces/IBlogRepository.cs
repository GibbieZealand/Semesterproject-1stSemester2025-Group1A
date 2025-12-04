using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    public interface IBlogRepository
    {
        void AddBlog(IBlog b);
        void RemoveBlog(IBlog b);
        List<IBlog> GetAllBlogs();
        void PrintAll();
    }
}
