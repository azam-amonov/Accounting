using MicrosAccounting.Api.Models.Transactions;
using Microsoft.EntityFrameworkCore;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    private static void AddTransactionsConfiguration(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transaction>()
            .HasOne(transaction => transaction.Category)
            .WithMany(category => category.Transactions)
            .HasForeignKey(transaction => transaction.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Transaction>()
            .HasOne(transaction => transaction.User)
            .WithMany(user => user.Transactions)
            .HasForeignKey(transaction => transaction.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}