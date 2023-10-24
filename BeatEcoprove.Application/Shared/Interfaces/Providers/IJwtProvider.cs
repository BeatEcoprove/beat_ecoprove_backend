using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IJwtProvider
{
    string GenerateToken(TokenPayload payload, Tokens token);
    Task<IDictionary<string, string>> GetClaims(string token);
}