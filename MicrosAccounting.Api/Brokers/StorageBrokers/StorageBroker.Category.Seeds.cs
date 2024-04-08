using MicrosAccounting.Api.Models.Categories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    public void SeedCategory(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Salary",
                Accounting = CategoryAccount.Income,
                Transactions = null
            },
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Other Income",
                Accounting = CategoryAccount.Income,
                Transactions = null
            },
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Food",
                Accounting = CategoryAccount.Expense,
                Transactions = null
            },
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Transport",
                Accounting = CategoryAccount.Expense,
                Transactions = null
            },
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Mobile Connection",
                Accounting = CategoryAccount.Expense,
                Transactions = null
            },
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Internet",
                Accounting = CategoryAccount.Expense,
                Transactions = null
            },
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Entertainment",
                Accounting = CategoryAccount.Expense,
                Transactions = null
            }
        );
    }
}