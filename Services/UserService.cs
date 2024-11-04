using Blog_WebApp.DisplayModel;
using Blog_WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _userRepository.GetAllAsync();
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _userRepository.GetByIdAsync(id);
    }

    public async Task AddUserAsync(User user)
    {
        await _userRepository.AddAsync(user);
    }

    public async Task UpdateUserAsync(User user)
    {
        await _userRepository.UpdateAsync(user);
    }

    public async Task DeleteUserAsync(int id)
    {
        await _userRepository.DeleteAsync(id);
    }
    public async Task<IEnumerable<GetUserDetailsDto>> GetUserDetails(int id)
    {
        return await _userRepository.GetUserDetails(id);
    }

    public async Task<User> Login(User user)
    {
        var authenticatedUser = await _userRepository.LoginAsync(user);
        return authenticatedUser;
    }
}
