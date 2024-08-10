using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace JWTJaswerAPI;

public class UserRole
{
    [Key]
    public int UsertRoleId { get; set; }
    [ForeignKey("User")]
    public Guid UserId { get; set; } 
    [ForeignKey("Role")]
    public Guid RoleId { get; set; }

    public Role Role { get; set; } = default!;
    public User User { get; set; } = default!;
}

public class UserRoleRequest
{
    public string? Email { get; set; }
    public string? RoleName { get; set;}
}
