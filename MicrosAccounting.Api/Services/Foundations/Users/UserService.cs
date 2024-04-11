using MicrosAccounting.Api.Brokers.StorageBrokers;
using MicrosAccounting.Api.Brokers.Tokens;
using MicrosAccounting.Api.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace MicrosAccounting.Api.Services.Foundations.Users;

public class UserService: IUserService
{
    private readonly IStorageBroker storageBroker;
    private readonly ITokenBroker tokenBroker;

    public UserService(IStorageBroker storageBroker, ITokenBroker tokenBroker)
    {
        this.storageBroker = storageBroker;
        this.tokenBroker = tokenBroker;
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

    public async ValueTask<string> SignUpAsync(string email, string password)
    {
        var user = await RetrieveUserByEmailAsync(email);
        if (user is null || user.Password != password)
            return "Invalid email or password!";

        var token = this.tokenBroker.GenerateJwt(email, password);

        return token;
    }

    public ValueTask<User> ModifyUserAsync(User user) =>
        this.storageBroker.UpdateUserAsync(user);

    public async ValueTask<User> RemoveUserByIdAsync(Guid userId) =>
        await this.storageBroker.DeleteUserByIdAsync(userId);
}