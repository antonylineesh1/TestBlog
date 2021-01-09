using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlog.Repository.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
