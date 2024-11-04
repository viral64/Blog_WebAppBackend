using Blog_WebApp.DisplayModel;
using Blog_WebApp.Models;
using Microsoft.EntityFrameworkCore;

public class BlogRepository : Repository<Blog>, IBlogRepository
{
    private readonly BlogWebContext _blogWebContext;
    public BlogRepository(BlogWebContext context) : base(context)
    {
        _blogWebContext = context;
    }

    public async Task<IEnumerable<BlogDto>> GetAllBlog()
    {
        IEnumerable<BlogDto> blogs;
        try
        {
            List<Blog> data = new List<Blog>();
            blogs = await _blogWebContext.Database
            .SqlQueryRaw<BlogDto>("EXEC getAllBlog")
            .ToListAsync();
        }
        catch (Exception ex) {
            throw new Exception();
        }

        return blogs;
    }

}