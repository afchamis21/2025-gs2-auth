using Microsoft.EntityFrameworkCore;
using ModelChanger.AuthService.Data;
using ModelChanger.AuthService.Entities;

namespace ModelChanger.AuthService.Repositories;

public class UserRepository: IUserRepository
{
    private readonly AuthDbContext _context;

    public UserRepository(AuthDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetByEmail(string email)
    {
        return await _context.Users.Where(u => u.Email == email).FirstOrDefaultAsync();
    }

    public async Task<User?> LoginAsync(string email, string password)
    {
        var user = await GetByEmail(email);

        if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            return user;
        }

        return null;
    }
}