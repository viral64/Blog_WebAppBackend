using Blog_WebApp.Models;

namespace Blog_WebApp.Services
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetAllBlogAsync();
        Task<Blog> GetBlogByIdAsync(int id);
        Task AddBlogAsync(Blog blog);    
        Task UpdateBlogAsync(Blog blog);
        Task DeleteBlogByIdAsync(int id);
    }
}
