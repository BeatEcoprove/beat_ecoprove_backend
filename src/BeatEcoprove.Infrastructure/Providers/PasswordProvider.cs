using BeatEcoprove.Application;

using BC = BCrypt.Net.BCrypt;

namespace BeatEcoprove.Infrastructure.Providers;

public class PasswordProvider : IPasswordProvider
{
    private const int EncriptCost = 12;

    public string HashPassword(string password)
    {
        return BC.HashPassword(password, EncriptCost);
    }

    public bool VerifyPassword(string password, string passwordHash)
    {
        return BC.Verify(password, passwordHash);
    }
}