using System.ComponentModel.DataAnnotations;

namespace JWTJaswerAPI;

public class Role
{

    public Role(string roleName)
    {   
        RoleName = roleName;
    }

    [Key]
    public Guid RoleId { get; set; }
    public string? RoleName { get; set; }    
}
