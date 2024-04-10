using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace MicrosAccounting.Api.Services.Foundations.Users;

public class UserService: IUserService
{
    private readonly IStorageBroker storageBroker;

    public UserService(IStorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
    }

    public ValueTask<User> AddUserAsync(User user) =>
        this.storageBroker.InsertUserAsync(user);

    public IQueryable<User> RetrieveAllUsers() =>
        this.storageBroker.SelectAllUsers();

    public async ValueTask<User?> RetrieveUserById(Guid userId) =>
        await this.storageBroker.SelectUserByIdAsync(userId);

    public async ValueTask<User> RetrieveUserByEmailAsync(string email)
    {
        var users = this.storageBroker.SelectAllUsers();
        var maybeUser = await users.FirstOrDefaultAsync(user =>
            user.Email == email);

        return maybeUser;
    }

    public ValueTask<User> ModifyUserAsync(User user) =>
        this.storageBroker.UpdateUserAsync(user);

    public async ValueTask<User> RemoveUserByIdAsync(Guid userId) =>
        await this.storageBroker.DeleteUserByIdAsync(userId);
}