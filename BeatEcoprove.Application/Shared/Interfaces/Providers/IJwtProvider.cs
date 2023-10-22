using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IJwtProvider
{
    string GenerateToken(Guid userId, string email, string name, Tokens token);
    Task<IDictionary<string, string>> GetClaims(string token);
}