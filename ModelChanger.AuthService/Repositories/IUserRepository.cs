using ModelChanger.AuthService.Entities;

namespace ModelChanger.AuthService.Repositories;

public interface IUserRepository
{
    Task<User?> GetByEmail(string email);
    Task<User?> LoginAsync(string email, string password);
}