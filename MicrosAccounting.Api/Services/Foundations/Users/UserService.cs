using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Models.Users;

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
    
    public ValueTask<User> ModifyUserAsync(User user) =>
        this.storageBroker.UpdateUserAsync(user);

    public async ValueTask<User> RemoveUserAsync(User user) =>
        await this.storageBroker.DeleteUserAsync(user);
}