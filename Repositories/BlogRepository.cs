using Blog_WebApp.Models;
using Microsoft.EntityFrameworkCore;

public class BlogRepository : Repository<Blog>, IBlogRepository
{
    public BlogRepository(BlogWebContext context) : base(context)
    {
    }
}