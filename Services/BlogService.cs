using Blog_WebApp.Models;

namespace Blog_WebApp.Services
{
    public class BlogService:IBlogService
    {
        private readonly IRepository<Blog> _blogRepository;
        public  BlogService(IRepository<Blog> repository)
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

        public Task<Blog> GetBlogByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlogAsync(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
