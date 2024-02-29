using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts.Authentication.Common;

using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Queries.Login;

public record LoginQuery
(
    string Email,
    string Password
) : IQuery<ErrorOr<AuthenticationResult>>;