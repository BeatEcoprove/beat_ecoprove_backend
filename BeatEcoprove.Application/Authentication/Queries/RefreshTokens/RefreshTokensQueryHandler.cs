using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;
using Microsoft.IdentityModel.Tokens;

namespace BeatEcoprove.Application.Authentication.Queries.RefreshTokens;

internal sealed class RefreshTokensQueryHandler : IQueryHandler<RefreshTokensQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtProvider _jwtProvider;

    public RefreshTokensQueryHandler(IJwtProvider jwtProvider)
    {
        _jwtProvider = jwtProvider;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(RefreshTokensQuery request, CancellationToken cancellationToken)
    {
        IDictionary<string, string> claims;
        
        try
        {
            claims = await _jwtProvider.GetClaims(request.RefreshToken);
        }
        catch (SecurityTokenException e)
        {
            return Errors.Token.InvalidRefreshToken;
        }

        var payload = new TokenPayload(
            Guid.Parse(claims[UserClaims.UserId]),
            claims[UserClaims.Email],
            claims[UserClaims.UserName],
            claims[UserClaims.AvatarUrl],
            10,
            10,
            10);

        var accessToken = _jwtProvider.GenerateToken(payload, Tokens.Access);
        var refreshToken = _jwtProvider.GenerateToken(payload, Tokens.Refresh);

        return new AuthenticationResult(
            accessToken,
            refreshToken);
    }
}