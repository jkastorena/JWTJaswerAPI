using Microsoft.EntityFrameworkCore;

namespace JWTJaswerAPI;

public class APIContext : DbContext
{   

    public APIContext(DbContextOptions options ) : base(options) {}

    public DbSet<User> Users {get; set;}
    public DbSet<Role> Roles {get; set;}
    public DbSet<UserRole> UsersRoles {get; set;}

    
    protected override void OnModelCreating(ModelBuilder modelBuilder){
    modelBuilder.Entity<User>()
        .HasIndex(b => b.Email)
        .IsUnique();
    modelBuilder.Entity<User>()
        .HasIndex(b => b.Phone)
        .IsUnique();

    modelBuilder.Entity<Role>()
        .HasIndex(b => b.RoleName)
        .IsUnique();
    }
}

