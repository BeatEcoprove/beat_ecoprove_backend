using BeatEcoprove.Application.Shared.Helpers;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IJwtProvider
{
    string GenerateToken(TokenPayload payload);
    Task<bool> ValidateToken(string token);
    Task<Dictionary<string, string>> GetClaims(string token);
}