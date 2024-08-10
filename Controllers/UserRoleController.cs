using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWTJaswerAPI;

[ApiController]
[Route("api/[Controller]")]
public class UserRoleController : ControllerBase
{

    private APIContext _context;

    public UserRoleController(APIContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _context.UsersRoles.ToListAsync()); 
    }

    [HttpPost]
    public async Task<IActionResult> Post(UserRole userRole)
    {
        if (userRole == null) return BadRequest("User Not valid");

        await _context.UsersRoles.AddAsync(userRole);
        await _context.SaveChangesAsync();

        return Ok(userRole);
    }

}
