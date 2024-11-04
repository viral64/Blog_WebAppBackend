using Blog_WebApp.DisplayModel;
using Blog_WebApp.Models;

public interface IUserRepository : IRepository<User>
{
    // You can add user-specific methods here if needed
    Task<User> LoginAsync(User user);
    Task<IEnumerable<GetUserDetailsDto>> GetUserDetails(int id);
}
