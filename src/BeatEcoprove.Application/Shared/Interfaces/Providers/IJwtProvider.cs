using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IJwtProvider
{
    string GenerateToken(TokenPayload payload);
    Task<bool> ValidateTokenAsync(string token, CancellationToken cancellationToken = default);
    Task<Dictionary<string, string>> GetClaims(string token);
    (string, string) GenerateAuthenticationTokens(Auth account, Profile profile, ProfileId profileId);
    (string, string) MapClaimsToAuthToken(IDictionary<string, string> claims);
    string GenerateRandomCode(int length);
}