namespace TestBlog.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
    }
}
