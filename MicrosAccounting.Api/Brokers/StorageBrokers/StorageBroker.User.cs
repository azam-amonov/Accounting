using MicrosAccounting.Api.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    public DbSet<User> Users { get; set; }
    
    public async ValueTask<User> InsertUserAsync(User user) =>
        await this.InsertAsync(user);

    public IQueryable<User> SelectAllUsers() =>
        this.SelectAll<User>();

    public async ValueTask<User?> SelectUserByIdAsync(Guid userId) =>
        await this.SelectAsync<User>(userId);
    public async ValueTask<User> UpdateUserAsync(User user) =>
        await this.UpdateAsync(user);
    
    public async ValueTask<User> DeleteUserAsync(User user) =>
        await this.DeleteAsync(user);
}