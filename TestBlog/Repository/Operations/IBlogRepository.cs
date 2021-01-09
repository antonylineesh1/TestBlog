using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;
using TestBlog.Repository.Entities;

namespace TestBlog.Repository.Operations
{
    public interface IBlogRepository
    {
        Task<Blog> CreateBlog(Blog blog);
        Task<Blog> GetBlog(int id);
        Task<Blog> EditBlog(Blog blogToEdit);
    }
}
