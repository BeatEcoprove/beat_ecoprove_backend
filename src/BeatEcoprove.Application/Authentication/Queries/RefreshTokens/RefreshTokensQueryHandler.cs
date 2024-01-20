using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;
using Microsoft.IdentityModel.Tokens;

namespace BeatEcoprove.Application.Authentication.Queries.RefreshTokens;

internal sealed class RefreshTokensQueryHandler : IQueryHandler<RefreshTokensQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtProvider _jwtProvider;
    private readonly IAuthRepository _authRepository;
    private readonly IProfileManager _profileManager;

    public RefreshTokensQueryHandler(
        IJwtProvider jwtProvider, 
        IAuthRepository authRepository, 
        IProfileManager profileManager)
    {
        _jwtProvider = jwtProvider;
        _authRepository = authRepository;
        _profileManager = profileManager;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(RefreshTokensQuery request, CancellationToken cancellationToken)
    {
        var profileId = ProfileId.Create(request.ProfileId);
        IDictionary<string, string> claims;

        try
        {
            claims = await _jwtProvider.GetClaims(request.RefreshToken);
        }
        catch (SecurityTokenException)
        {
            return Errors.Token.InvalidRefreshToken;
        }

        var authId = AuthId.Create(Guid.Parse(claims[UserClaims.AccountId]));
        var auth = await _authRepository.GetByIdAsync(authId, cancellationToken);

        if (auth is null)
        {
            return Errors.Auth.InvalidAuth;
        }

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var ( accessToken, refreshToken ) =
            _jwtProvider.GenerateAuthenticationTokens(auth, profile.Value);

        return new AuthenticationResult(
            accessToken,
            refreshToken);
    }
}