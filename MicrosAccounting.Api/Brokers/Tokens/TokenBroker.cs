using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using MicrosAccounting.Api.Models.Tokens;
using MicrosAccounting.Api.Models.Users;
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

    public string GenerateJwt(User user)
    {
        byte[] convertedKeyToBytes = 
            Encoding.UTF8.GetBytes(this.tokenConfiguration.Key);

        var securityKey = new SymmetricSecurityKey(convertedKeyToBytes);
        var credentials = 
            new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email),
        };

        var token = new JwtSecurityToken(
            issuer: this.tokenConfiguration.Issuer,
            audience: this.tokenConfiguration.Audience,
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public string HashToken(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }
    }
}