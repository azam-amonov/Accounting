using MicrosAccounting.Api.Models.Users;

namespace MicrosAccounting.Api.Services.Foundations.Users;

public interface IUserService
{
    ValueTask<User> AddUserAsync(User user);
    IQueryable<User> RetrieveAllUsers();
}