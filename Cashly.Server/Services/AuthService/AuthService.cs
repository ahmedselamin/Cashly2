
using System.Security.Cryptography;

namespace Cashly.Server.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly DataContext _context;

    public AuthService(DataContext context)
    {
        _context = context;
    }
    public Task<ServiceResponse<int>> Register(User user, string password)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<string>> Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<bool>> DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UserExists(string username)
    {
        if (await _context.Users.AnyAsync(user => user.Username.ToLower()
                    .Equals(username.ToLower())))
        {
            return true;
        }

        return false;
    }

    public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }


}
