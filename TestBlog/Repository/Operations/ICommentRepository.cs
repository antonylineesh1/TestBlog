using System.Threading.Tasks;
using TestBlog.Repository.Entities;

namespace TestBlog.Repository.Operations
{
    public interface ICommentRepository
    {
        Task<Comment> CreateComment(Comment comment);
    }
}
