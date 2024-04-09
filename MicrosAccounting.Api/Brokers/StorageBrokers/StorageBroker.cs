using EFxceptions;
using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Models.Transactions;
using MicrosAccounting.Api.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker : EFxceptionsContext, IStorageBroker
{
    private readonly IConfiguration configuration;

    public StorageBroker(IConfiguration configuration)
    {
        this.configuration = configuration;
        this.Database.Migrate();
    }

    private async ValueTask<T> InsertAsync<T>(T @object)
    {
        var broker = new StorageBroker(this.configuration);
        broker.Entry(@object).State = EntityState.Added;
        await broker.SaveChangesAsync();

        return @object;
    }

    private IQueryable<T> SelectAll<T>() where T :class
    {
        var broker = new StorageBroker(this.configuration);
        return broker.Set<T>();
    }

    private async ValueTask<T?> SelectAsync<T>(params object[] objectIds) where T : class =>
        await FindAsync<T>(objectIds);
    
    private async ValueTask<T> UpdateAsync<T>(T @object)
    {
        var broker = new StorageBroker(this.configuration);
        broker.Entry(@object).State = EntityState.Modified;
        await broker.SaveChangesAsync();
        
        return @object;
    }

    private async ValueTask<T> DeleteAsync<T>(T @object)
    {
        var broker = new StorageBroker(this.configuration);
        broker.Entry(@object).State = EntityState.Deleted;
        await broker.SaveChangesAsync();
        
        return @object;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = this.configuration.
            GetConnectionString("DefaultConnection");

        optionsBuilder.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // configurations
        AddUserConfiguration(modelBuilder);
        AddCategoryConfiguration(modelBuilder);
        AddTransactionsConfiguration(modelBuilder);
        
        // seed data
        SeedUser(modelBuilder.Entity<User>());
        SeedCategory(modelBuilder.Entity<Category>());
        SeedTransaction(modelBuilder.Entity<Transaction>());
    }
}