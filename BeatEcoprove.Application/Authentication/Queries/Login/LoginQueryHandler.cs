using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Queries.Login;

internal sealed class LoginQueryHandler : IQueryHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IPasswordProvider _passwordProvider;

    public LoginQueryHandler(
        IUserRepository userRepository,
        IJwtProvider jwtProvider,
        IPasswordProvider passwordProvider)
    {
        _userRepository = userRepository;
        _jwtProvider = jwtProvider;
        _passwordProvider = passwordProvider;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);
        var password = Password.Create(request.Password);

        var result = email.AddValidate(password);
        if (result.IsError) return result.Errors;

        var user = await _userRepository.GetUserByEmail(email.Value, cancellationToken);

        // Verify user already exists
        if (user is null)
        {
            return Errors.User.EmailDoesNotExists;
        }

        // Verify password is correct
        if (!_passwordProvider.VerifyPassword(password.Value, user.Password))
        {
            return Errors.User.BadCredentials;
        }

        // Generate Tokens
        var payload = new AuthTokenPayload(
            user.Id,
            user.Email,
            user.Name,
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