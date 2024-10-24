using Blog_WebApp.Models;

namespace Blog_WebApp.Services
{
    public class BlogService:IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public  BlogService(IBlogRepository repository)
        {
            _blogRepository = repository;
        }

        public Task AddBlogAsync(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlogByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Blog>> GetAllBlogAsync()
        {
            return await _blogRepository.GetAllAsync();
        }

        public async Task<Blog> GetBlogByIdAsync(int id)
        {
            return await _blogRepository.GetByIdAsync(id);
        }

        public Task UpdateBlogAsync(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
