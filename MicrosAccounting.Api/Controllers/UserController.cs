using MicrosAccounting.Api.Models.Users;
using MicrosAccounting.Api.Services.Foundations.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MicrosAccounting.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService userService;

    public UserController(IUserService userService)
    {
        this.userService = userService;
    }
    
    [HttpGet]
    public ActionResult<IQueryable<User>> GetAllUsers()
    {
        IQueryable<User> retrievedUsers = this.userService.RetrieveAllUsers();
        return Ok(retrievedUsers);
    }

    [HttpPost]
    public async ValueTask<ActionResult<User>> PostUserAsync(User user)
    {
        User addedUser = await this.userService.AddUserAsync(user);
        return Ok(addedUser);
    }
    
    [HttpGet("{userId}")]
    public async ValueTask<ActionResult<User>> GetUserById(Guid userId)
    {
        User? user = await this.userService.RetrieveUserById(userId);
        
        return Ok(user);
    }

    [Authorize]
    [HttpPut]
    public async ValueTask<ActionResult<User>> PutUserAsync(User user)
    {
        User modifiedUser = await this.userService.ModifyUserAsync(user);
        return Ok(modifiedUser);
    }

    [Authorize]
    [HttpDelete("{userId}")]
    public async ValueTask<ActionResult<User>> DeleteUserAsyncById(Guid userId)
    {
        User deletedUser = await this.userService.RemoveUserByIdAsync(userId);
        
        return Ok(deletedUser);
    }
}