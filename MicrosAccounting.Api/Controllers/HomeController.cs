using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MicrosAccounting.Api.Services.Foundations.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace MicrosAccounting.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly IConfiguration configuration;
    private readonly IUserService userService;

    public HomeController(IConfiguration configuration, IUserService userService)
    {
        this.configuration = configuration;
        this.userService = userService;
    }

    [HttpPost]
    public async ValueTask<ActionResult<string>> Post(string email, string password)
    {

        var user = await this.userService.RetrieveUserByEmailAsync(email);
        if (user is null || user.Password != password)
            return Unauthorized("Invalid email or password!");

        var userClaims = new[]
        {
            new Claim(ClaimTypes.Name, user.Email)
        };
            
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var securityToken = new JwtSecurityToken(configuration["Jwt:Issuer"],
            audience: configuration["Jwt:Issuer"], 
            claims: userClaims, 
            expires: DateTime.Now.AddMinutes(3600),
            signingCredentials: credentials);

        var token = new JwtSecurityTokenHandler().WriteToken(securityToken);

        return Ok(token);
    }
    
    [Authorize] 
    [HttpGet]
    public IActionResult Get() 
    { 
        return Ok("Hello World"); 
    }
}