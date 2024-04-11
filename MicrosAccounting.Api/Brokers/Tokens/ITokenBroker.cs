using MicrosAccounting.Api.Models.Users;

namespace MicrosAccounting.Api.Brokers.Tokens;

public interface ITokenBroker
{
    string GenerateJwt(User user);
    string Token(string password);
}