using Blog_WebApp.DisplayModel;
using Blog_WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IUserService
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task<User> GetUserByIdAsync(int id);
    Task AddUserAsync(User user);
    Task UpdateUserAsync(User user);
    Task DeleteUserAsync(int id);
    Task<User> Login(User user);
    Task<IEnumerable<GetUserDetailsDto>> GetUserDetails(int id);
}
