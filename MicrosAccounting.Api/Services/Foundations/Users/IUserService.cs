using MicrosAccounting.Api.Models.Users;

namespace MicrosAccounting.Api.Services.Foundations.Users;

public interface IUserService
{
    ValueTask<User> AddUserAsync(User user);
    IQueryable<User> RetrieveAllUsers();
    ValueTask<User?> RetrieveUserById(Guid userId);
    ValueTask<User> RetrieveUserByEmailAsync(string email);
    ValueTask<string> SignUpAsync(string email, string password);
    ValueTask<User> ModifyUserAsync(User user);
    ValueTask<User> RemoveUserByIdAsync(Guid userId);
}