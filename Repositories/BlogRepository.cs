using Blog_WebApp.Models;
using Microsoft.EntityFrameworkCore;

public class BlogRepository : Repository<Blog>, IBlogRepository
{
    private readonly BlogWebContext _blogWebContext;
    public BlogRepository(BlogWebContext context) : base(context)
    {
        _blogWebContext = context;
    }

    public async Task<IEnumerable<Blog>> GetAllBlog()
    {
        var blog = _blogWebContext.Blogs.ToList();
        List<Blog> result = new List<Blog>();
        for(int i = 0; i < blog.Count; i++)
        {
            if (!blog[i].IsDeleted)
            {

            }
        }
        return blog;
    }

}