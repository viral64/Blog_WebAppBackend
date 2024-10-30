using Blog_WebApp.Models;

public interface IBlogRepository : IRepository<Blog>
{
    // You can add user-specific methods here if needed
    Task<IEnumerable<Blog>> GetAllBlog();
}
