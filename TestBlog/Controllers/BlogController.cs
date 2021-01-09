using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using TestBlog.Models;
using TestBlog.Repository.Entities;
using TestBlog.Repository.Operations;

namespace TestBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;

        public string UserId => User.FindFirstValue(ClaimTypes.NameIdentifier);
        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;

        }
        [HttpPost]
        public async Task<IActionResult> Post(BlogDTO blog)
        {
            //todo automapper
            Blog blogToCreate = new Blog { UserId = UserId, Description = blog.Description };
            Blog createdBlog = await _blogRepository.CreateBlog(blogToCreate);
            blog.Id = createdBlog.Id;
            return Ok(blog);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
           Blog blog=await _blogRepository.GetBlog(id);
           //todo automapper
           if (blog is null)
                return NotFound();
            return Ok(blog);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, BlogDTO blog) 
        {

            Blog blogToEdit = await _blogRepository.GetBlog(id);
            if (blogToEdit is null)
                return NotFound();
            if (blogToEdit.UserId != UserId) return Unauthorized();
            blogToEdit.Description = blog.Description;

            await _blogRepository.EditBlog(blogToEdit);
            return Ok(blog);
        }


    }
}
