using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWTJaswerAPI;

[Route("api/[Controller]")]
[ApiController]
public class RoleController : ControllerBase
{
    
    private APIContext _context;

    public RoleController(APIContext apicontext)
    {
        _context = apicontext;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var roles = await _context.Roles.ToListAsync();
        return Ok(roles);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Role role)
    {
        await _context.Roles.AddAsync(role);
        _context.SaveChanges();

        return Ok(role);
    }

}
