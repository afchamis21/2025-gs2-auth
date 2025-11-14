using Microsoft.EntityFrameworkCore;
using ModelChanger.AuthService.Entities;

namespace ModelChanger.AuthService.Data;

public class AuthDbContext : DbContext
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}
