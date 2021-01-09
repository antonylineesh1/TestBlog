using System.Threading.Tasks;
using TestBlog.Repository.Data;
using TestBlog.Repository.Entities;

namespace TestBlog.Repository.Operations
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Comment> CreateComment(Comment comment)
        {
            await _context.AddAsync(comment);
            await _context.SaveChangesAsync();
            return comment;
        }
    }
}
