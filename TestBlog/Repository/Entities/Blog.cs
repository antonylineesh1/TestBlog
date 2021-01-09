using Microsoft.AspNetCore.Identity;

namespace TestBlog.Repository.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
