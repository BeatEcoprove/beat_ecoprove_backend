using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IJwtProvider
{
    string GenerateToken(TokenPayload payload);
    Task<bool> ValidateToken(string token);
    Task<Dictionary<string, string>> GetClaims(string token);
    (string, string) GenerateAuthenticationTokens(Auth account, Profile profile);
    (string, string) MapClaimsToAuthToken(IDictionary<string, string> claims);
    string GenerateRandomCode(int length);
}