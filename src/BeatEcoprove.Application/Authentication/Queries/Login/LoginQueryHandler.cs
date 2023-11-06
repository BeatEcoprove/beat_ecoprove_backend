using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
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

        // Verify user already exists
        if (auth is null)
        {
            return Errors.User.EmailDoesNotExists;
        }

        var profile = await _profileRepository.GetProfileByAuthId(auth.Id, cancellationToken);

        if (profile is null)
        {
            return Errors.User.ProfileDoesNotExists;
        }

        // Verify password is correct
        if (!_passwordProvider.VerifyPassword(password.Value, auth.Password))
        {
            return Errors.User.BadCredentials;
        }

        // Generate Tokens
        var payload = new AuthTokenPayload(
            auth.Id,
            auth.Email,
            profile.UserName,
            "https://github.com/DiogoCC7.png",
            10,
            10,
            10,
            Tokens.Access);

        var accessToken = _jwtProvider.GenerateToken(payload);

        payload.Type = Tokens.Refresh;
        var refreshToken = _jwtProvider.GenerateToken(payload);

        return new AuthenticationResult(
            accessToken,
            refreshToken);
    }
}