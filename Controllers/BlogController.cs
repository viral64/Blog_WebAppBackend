using Blog_WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Nest;
using Blog_WebApp.Models;
using Elastic.Clients.Elasticsearch;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Authorization;
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
            var blogs = await _blogService.GetAllBlog();
            return Ok(blogs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            var blog = await _blogService.GetBlogByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }

        [HttpPost]
        public async Task<IActionResult> AddBlog(Blog blog)
        {
            await _blogService.AddBlogAsync(blog);
            return CreatedAtAction(nameof(GetBlogById), new {id=blog.BlogId},blog);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _blogService.DeleteBlogByIdAsync(id);
            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(int id,Blog blog){
            if (id != blog.BlogId)
            {
                return BadRequest();
            }
            await _blogService.UpdateBlogAsync(blog);
            return NoContent();
        }
    }
}
