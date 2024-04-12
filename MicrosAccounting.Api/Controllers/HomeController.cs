using MicrosAccounting.Api.Services.Foundations.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MicrosAccounting.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly IUserService userService;
    
    public HomeController(IUserService userService)
    {
        this.userService = userService;
    }

    [HttpPost]
    public async ValueTask<ActionResult<string>> Login(string email, string password)
    {
       var token = this.userService.SignUpAsync(email, password);

        return Ok(token);
    }
    
    [Authorize] 
    [HttpGet]
    public IActionResult Get() 
    { 
        return Ok("Hello World"); 
    }
}