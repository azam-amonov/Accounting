using MicrosAccounting.Api.Models.Transactions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    private static void SeedTransaction(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasData(new Transaction
        {
            Id = Guid.Parse("7f45cc7a-75e5-43b3-9993-44a1a2f54c28"),
            UserId = Guid.Parse("47729a8b-e359-493e-a982-e7c818cd1220"), //User-1
            CategoryId = Guid.Parse("1a99ed58-54fc-4c2d-b68d-f0f8c96f88c8"), //salary
            TransactionDate = DateTimeOffset.Parse("2024-04-05"),
            Comment = "some comment",
            Amount = 6000,

        },
        new Transaction
        {
            Id = Guid.Parse("71065dfc-eaef-4f96-a1f9-5291a8467a86"), 
            UserId = Guid.Parse("8121adf5-6db9-46bb-ae3b-60b547526438"), //User-2
            CategoryId = Guid.Parse("71577dac-0a17-4a58-8285-7fdc5c008b4e"), // other income
            TransactionDate = DateTimeOffset.Parse("2024-04-02"),
            Comment = "some comment",
            Amount = 5000,

        },
        new Transaction
        {
            Id = Guid.Parse("5714ede8-db42-4fa0-845c-47ff57d29ff1"),
            UserId = Guid.Parse("47729a8b-e359-493e-a982-e7c818cd1220"),
            CategoryId = Guid.Parse("ed29109f-27df-43f5-b40d-8b2d12da3738"),
            TransactionDate = DateTimeOffset.Parse("2024-04-03"),
            Comment = "some comment",
            Amount = 100,

        },
        new Transaction
        {
            Id = Guid.Parse("72144c30-d401-4b4a-be4c-13dcf4a8e567"),
            UserId = Guid.Parse("47729a8b-e359-493e-a982-e7c818cd1220"),
            CategoryId = Guid.Parse("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"),
            TransactionDate = DateTimeOffset.Parse("2024-04-10"),
            Comment = "some comment",
            Amount = 500,

        },
        new Transaction
        {
            Id = Guid.Parse("070e7930-b979-43a2-b512-69ad2999c2c1"),
            UserId = Guid.Parse("8121adf5-6db9-46bb-ae3b-60b547526438"),
            CategoryId = Guid.Parse("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"),
            TransactionDate = DateTimeOffset.Parse("2024-04-03"),
            Comment = "some comment",
            Amount = 90,

        },
        new Transaction
        {
            Id = Guid.Parse("75b01b84-8590-4ce5-b2d6-b8fda47c2a4c"),
            UserId = Guid.Parse("47729a8b-e359-493e-a982-e7c818cd1220"),
            CategoryId = Guid.Parse("ed29109f-27df-43f5-b40d-8b2d12da3738"),
            TransactionDate = DateTimeOffset.Parse("2024-03-20"),
            Comment = "some comment",
            Amount = 101,

        },
        new Transaction
        {
            Id = Guid.Parse("75c56079-9619-44a3-88a4-7675b09817d0"),
            UserId = Guid.Parse("8121adf5-6db9-46bb-ae3b-60b547526438"),
            CategoryId = Guid.Parse("0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"),
            TransactionDate = DateTimeOffset.Parse("2024-03-02"),
            Comment = "some comment",
            Amount = 40,
        });
    }
}