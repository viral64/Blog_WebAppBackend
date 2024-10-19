using Blog_WebApp.Models;
using Microsoft.EntityFrameworkCore;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(BlogWebContext context) : base(context)
    {
    }
}