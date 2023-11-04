namespace BeatEcoprove.Application;

public interface IPasswordProvider
{
    string HashPassword(string password);
    bool VerifyPassword(string password, string passwordHash);
}
