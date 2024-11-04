using Blog_WebApp.DisplayModel;
using Blog_WebApp.Models;
using Microsoft.EntityFrameworkCore;

public class UserRepository : Repository<User>, IUserRepository
{
    private readonly BlogWebContext _blogWebContext;
    public UserRepository(BlogWebContext context) : base(context)
    {
        _blogWebContext = context;
    }
    public async Task<User?> LoginAsync(User user)
    {
        var authenticatedUser = await _blogWebContext.Users
            .FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);

        return authenticatedUser;
    }

    public async Task<IEnumerable<GetUserDetailsDto>> GetUserDetails(int id)
    {
        IEnumerable<GetUserDetailsDto> userDetails;
        try
        {
            userDetails = await _blogWebContext.Database
                .SqlQueryRaw<GetUserDetailsDto>("EXEC GetUserDetails @userid={0}", id)
                .ToListAsync();
            foreach (var detail in userDetails)
            {
                detail.DisplayTime = detail.hours_since_created > 24
                    ? $"{detail.hours_since_created / 24} days ago"
                    : $"{detail.hours_since_created}h ago";
            }
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while retrieving user details.", ex);
        }
       

        return userDetails;
    }
}