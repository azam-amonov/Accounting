using MicrosAccounting.Api.Models.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicrosAccounting.Api.Brokers.StorageBrokers;

public partial class StorageBroker
{
    private static void SeedUser(EntityTypeBuilder<User> builder)
    {
        builder.HasData(new User
        {
            Id = Guid.Parse("47729a8b-e359-493e-a982-e7c818cd1220"),
            Email = "adim@microsoft.com",
            Password = "Hello!11",
        });
    }
}