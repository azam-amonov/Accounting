using MicrosAccounting.Api.Models.Users;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial interface IStorageBroker
{
    ValueTask<User> InsertUserAsync(User user);
    IQueryable<User> SelectAllUsers();
    ValueTask<User?> SelectUserByIdAsync(Guid id);
    ValueTask<User> UpdateUserAsync(User user);
    ValueTask<User> DeleteUserByIdAsync(Guid userId);
}