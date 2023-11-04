using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts.Authentication.Common;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Queries.RefreshTokens;

public record RefreshTokensQuery
(
    string RefreshToken
) : IQuery<ErrorOr<AuthenticationResult>>;