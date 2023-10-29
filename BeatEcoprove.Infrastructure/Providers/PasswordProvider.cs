using BeatEcoprove.Application;
using BC = BCrypt.Net.BCrypt;

namespace BeatEcoprove.Infrastructure;

public class PasswordProvider : IPasswordProvider
{
    private const int ENCRIPT_COST = 12;

    public string HashPassword(string password)
    {
        return BC.HashPassword(password, ENCRIPT_COST);
    }

    public bool VerifyPassword(string password, string passwordHash)
    {
        return BC.Verify(password, passwordHash);
    }
}
