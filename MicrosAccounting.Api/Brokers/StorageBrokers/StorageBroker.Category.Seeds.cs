using MicrosAccounting.Api.Models.Categories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    private static void SeedCategory(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category
            {
                Id = Guid.Parse("1a99ed58-54fc-4c2d-b68d-f0f8c96f88c8"),
                Name = "Salary",
                Accounting = Accounting.Income,
                Transactions = null
            },
            new Category
            {
                Id = Guid.Parse("71577dac-0a17-4a58-8285-7fdc5c008b4e"),
                Name = "Other Income",
                Accounting = Accounting.Income,
                Transactions = null
            },
            new Category
            {
                Id = Guid.Parse("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"),
                Name = "Food",
                Accounting = Accounting.Expense,
                Transactions = null
            },
            new Category
            {
                Id = Guid.Parse("ed29109f-27df-43f5-b40d-8b2d12da3738"),
                Name = "Transport",
                Accounting = Accounting.Expense,
                Transactions = null
            },
            new Category
            {
                Id = Guid.Parse("e1b10d79-d2e0-40bf-86d2-f7f05b868e66"),
                Name = "Mobile Connection",
                Accounting = Accounting.Expense,
                Transactions = null
            },
            new Category
            {
                Id = Guid.Parse("ccabf5d2-4ad2-46c8-bd73-3d391f7ff918"),
                Name = "Internet",
                Accounting = Accounting.Expense,
                Transactions = null
            },
            new Category
            {
                Id = Guid.Parse("ba0c060a-2c9d-441d-837c-40aaaebd30a3"),
                Name = "Entertainment",
                Accounting = Accounting.Expense,
                Transactions = null
            }
        );
    }
}