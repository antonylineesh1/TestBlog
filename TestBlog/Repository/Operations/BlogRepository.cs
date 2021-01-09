using System.Threading.Tasks;
using TestBlog.Repository.Data;
using TestBlog.Repository.Entities;

namespace TestBlog.Repository.Operations
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ApplicationDbContext _context;

        public BlogRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Blog> CreateBlog(Blog blog)
        {
            await _context.AddAsync(blog);
            await _context.SaveChangesAsync();
            return blog;
        }

        public async Task<Blog> EditBlog(Blog blogToEdit)
        {
            await _context.SaveChangesAsync();
            return blogToEdit;
        }

        public async Task<Blog> GetBlog(int id)
        {
            return await _context.FindAsync<Blog>(id);
        }
    }
}
