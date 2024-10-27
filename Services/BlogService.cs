using Blog_WebApp.Models;
using System.Runtime.InteropServices;

namespace Blog_WebApp.Services
{
    public class BlogService:IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public  BlogService(IBlogRepository repository)
        {
            _blogRepository = repository;
        }

        public async Task AddBlogAsync(Blog blog)
        {
             await _blogRepository.AddAsync(blog);
        }

        public async Task DeleteBlogByIdAsync(int id)
        {
            await _blogRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Blog>> GetAllBlogAsync()
        {
            return await _blogRepository.GetAllAsync();
        }

        public async Task<Blog> GetBlogByIdAsync(int id)
        {
            return await _blogRepository.GetByIdAsync(id);
        }

        public async Task UpdateBlogAsync(Blog blog)
        {
            await _blogRepository.UpdateAsync(blog);
        }
    }
}
