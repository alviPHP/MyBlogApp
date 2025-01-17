using Blog.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.IRepository
{
    public interface IBlogRepository
    {
        Task<List<MyBlog>> GetAllBlogsAsync();
        Task<MyBlog> GetByIdAsync(int id);
        Task<MyBlog> CreateAsync(MyBlog blog);
        Task<int> UpdateAsync(int id, MyBlog blog);
        Task<int> DeleteAsync(int id);
    }
}
