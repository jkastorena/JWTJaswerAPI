using JWTJaswerAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWTJaswerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    private APIContext _haswContext;

    public UserController(APIContext haswContext)
    {
        _haswContext = haswContext;
    }

    [HttpPost]
    public async Task<IActionResult> Post(User user){
        if (user == null) return BadRequest("User Register Fail");

        await _haswContext.Users.AddAsync(user);
        _haswContext.SaveChanges();
        return Ok("User Register OK");
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await _haswContext.Users.ToListAsync();
        return Ok(users);
    }
   
}
