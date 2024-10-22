using Blog_WebApp.Services;
using Microsoft.AspNetCore.Mvc;
namespace Blog_WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController:ControllerBase
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlog()
        {
            var blogs = await _blogService.GetAllBlogAsync();
            return Ok(blogs);
        }
    }
}
