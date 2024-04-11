using MicrosAccounting.Api.Models.Users;

namespace MicrosAccounting.Api.Brokers.Tokens;

public interface ITokenBroker
{
    string GenerateJwt(User user);
    string HashToken(string password);
}