using MicrosAccounting.Api.Models.Transactions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    private void SeedTransaction(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasData(new Transaction
        {
            Id = Guid.Parse("b702cee4-a40e-469d-ba2e-45babb328813"),
            UserId = Guid.Parse("47729a8b-e359-493e-a982-e7c818cd1220"), //User-1
            CategoryId = Guid.Parse("1a99ed58-54fc-4c2d-b68d-f0f8c96f88c8"), //salary
            CreatedAt = DateTimeOffset.Parse("2024-04-05"),
            Comment = "some comment",
            Amount = 6000,

        },
        new Transaction
        {
            Id = Guid.Parse("b702cee4-a40e-469d-ba2e-45babb328815"), 
            UserId = Guid.Parse("8121adf5-6db9-46bb-ae3b-60b547526438"), //User-2
            CategoryId = Guid.Parse("71577dac-0a17-4a58-8285-7fdc5c008b4e"), // other income
            CreatedAt = DateTimeOffset.Parse("2024-04-02"),
            Comment = "some comment",
            Amount = 5000,

        },
        new Transaction
        {
            Id = Guid.Parse("b702cee4-a40e-469d-ba2e-45babb328814"),
            UserId = Guid.Parse("47729a8b-e359-493e-a982-e7c818cd1220"),
            CategoryId = Guid.Parse("ed29109f-27df-43f5-b40d-8b2d12da3738"),
            CreatedAt = DateTimeOffset.Parse("2024-04-03"),
            Comment = "some comment",
            Amount = 100,

        },
        new Transaction
        {
            Id = Guid.Parse("b702cee4-a40e-469d-ba2e-45babb328815"),
            UserId = Guid.Parse("47729a8b-e359-493e-a982-e7c818cd1220"),
            CategoryId = Guid.Parse("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"),
            CreatedAt = DateTimeOffset.Parse("2024-04-10"),
            Comment = "some comment",
            Amount = 500,

        },
        new Transaction
        {
            Id = Guid.Parse("b702cee4-a40e-469d-ba2e-45babb328816"),
            UserId = Guid.Parse("8121adf5-6db9-46bb-ae3b-60b547526438"),
            CategoryId = Guid.Parse("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"),
            CreatedAt = DateTimeOffset.Parse("2024-04-03"),
            Comment = "some comment",
            Amount = 90,

        },
        new Transaction
        {
            Id = Guid.Parse("b702cee4-a40e-469d-ba2e-45babb328817"),
            UserId = Guid.Parse("47729a8b-e359-493e-a982-e7c818cd1220"),
            CategoryId = Guid.Parse("ed29109f-27df-43f5-b40d-8b2d12da3738"),
            CreatedAt = DateTimeOffset.Parse("2024-03-20"),
            Comment = "some comment",
            Amount = 101,

        },
        new Transaction
        {
            Id = Guid.Parse("b702cee4-a40e-469d-ba2e-45babb328818"),
            UserId = Guid.Parse("8121adf5-6db9-46bb-ae3b-60b547526438"),
            CategoryId = Guid.Parse("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"),
            CreatedAt = DateTimeOffset.Parse("2024-03-02"),
            Comment = "some comment",
            Amount = 40,
        });
    }
}