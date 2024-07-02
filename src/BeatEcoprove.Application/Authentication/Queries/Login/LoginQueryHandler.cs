using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;

using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Queries.Login;

internal sealed class LoginQueryHandler : IQueryHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IAuthRepository _authRepository;
    private readonly IProfileRepository _profileRepository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IPasswordProvider _passwordProvider;

    public LoginQueryHandler(
        IAuthRepository authRepository,
        IProfileRepository profileRepository,
        IJwtProvider jwtProvider,
        IPasswordProvider passwordProvider)
    {
        _authRepository = authRepository;
        _profileRepository = profileRepository;
        _jwtProvider = jwtProvider;
        _passwordProvider = passwordProvider;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);
        var password = Password.Create(request.Password);

        var result = email.AddValidate(password);
        if (result.IsError) return result.Errors;

        var auth = await _authRepository.GetAuthByEmail(email.Value, cancellationToken);

        if (auth is null)
        {
            return Errors.User.EmailDoesNotExists;
        }

        var profile = await _authRepository.GetMainProfile(auth.Id, cancellationToken);

        if (profile is null)
        {
            return Errors.User.ProfileDoesNotExists;
        }

        if (!_passwordProvider.VerifyPassword(password.Value, auth.Password))
        {
            return Errors.User.BadCredentials;
        }

        (string accessToken, string refreshToken) =
            _jwtProvider
                .GenerateAuthenticationTokens(auth, profile, profile.Id);

        return new AuthenticationResult(
            accessToken,
            refreshToken);
    }
}