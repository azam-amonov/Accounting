using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MicrosAccounting.Api.Models.Tokens;
using Microsoft.IdentityModel.Tokens;

namespace MicrosAccounting.Api.Brokers.Tokens;

public class TokenBroker : ITokenBroker
{
    private readonly TokenConfiguration tokenConfiguration;

    public TokenBroker(IConfiguration configuration)
    {
        this.tokenConfiguration = new TokenConfiguration();
        configuration.Bind("Jwt", this.tokenConfiguration);
    }

    public string GenerateJwt(string email, string password)
    {
        byte[] convertedKeyToBytes = 
            Encoding.UTF8.GetBytes(this.tokenConfiguration.Key);

        var securityKey = new SymmetricSecurityKey(convertedKeyToBytes);
        var credentials = 
            new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, email),
        };

        var token = new JwtSecurityToken(
            issuer: this.tokenConfiguration.Issuer,
            audience: this.tokenConfiguration.Issuer,
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}