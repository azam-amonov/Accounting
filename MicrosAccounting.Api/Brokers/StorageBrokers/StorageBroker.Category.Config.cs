using MicrosAccounting.Api.Models.Categories;
using Microsoft.EntityFrameworkCore;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    private static void AddCategoryConfiguration(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(category => category.Transactions)
            .WithOne(transaction => transaction.Category)
            .HasForeignKey(transaction => transaction.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}