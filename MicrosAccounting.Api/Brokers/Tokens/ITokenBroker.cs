using MicrosAccounting.Api.Models.Users;

namespace MicrosAccounting.Api.Brokers.Tokens;

public interface ITokenBroker
{
    string GenerateJwt(string email, string password);
}