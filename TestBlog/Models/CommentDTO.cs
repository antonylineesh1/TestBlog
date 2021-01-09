using System.ComponentModel.DataAnnotations;

namespace TestBlog.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
