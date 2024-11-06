using Blog_WebApp.DisplayModel;
using Blog_WebApp.Models;
using Blog_WebApp.Repositories.StoredProcedureDto;
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
        IEnumerable<GetUserDetailsIntermediateDto> intermediateUserDetails;
        try
        {
            intermediateUserDetails = await _blogWebContext.Database
                .SqlQueryRaw<GetUserDetailsIntermediateDto>("EXEC GetUserDetails @userid={0}", id)
                .ToListAsync();

            // Map to GetUserDetailsDto and set DisplayTime
            var userDetails = intermediateUserDetails.Select(detail => new GetUserDetailsDto
            {
                user_id = detail.user_id,
                username = detail.username,
                profile_picture = detail.profile_picture,
                title = detail.title,
                content = detail.content,
                DisplayTime = detail.hours_since_created > 24
                    ? $"{detail.hours_since_created / 24} days ago"
                    : $"{detail.hours_since_created}h ago"
            }).ToList();

            return userDetails;
        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred while retrieving user details.", ex);
        }
    }
}