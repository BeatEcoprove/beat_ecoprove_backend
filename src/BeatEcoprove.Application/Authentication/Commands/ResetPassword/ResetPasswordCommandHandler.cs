using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

using Microsoft.IdentityModel.Tokens;

namespace BeatEcoprove.Application.Authentication.Commands.ResetPassword;

internal sealed class ResetPasswordCommandHandler : ICommandHandler<ResetPasswordCommand, ErrorOr<string>>
{
    private readonly IJwtProvider _jwtProvider;
    private readonly IAuthRepository _authRepository;
    private readonly IPasswordProvider _passwordProvider;
    private readonly IKeyValueRepository<string> _keyValueRepository;

    public ResetPasswordCommandHandler(
        IJwtProvider jwtProvider,
        IAuthRepository authRepository,
        IPasswordProvider passwordProvider,
        IKeyValueRepository<string> keyValueRepository)
    {
        _jwtProvider = jwtProvider;
        _authRepository = authRepository;
        _passwordProvider = passwordProvider;
        _keyValueRepository = keyValueRepository;
    }

    public async Task<ErrorOr<string>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
    {
        IDictionary<string, string> claims;
        ErrorOr<Email> email;

        var password = Password.Create(request.Password);

        if (password.IsError)
        {
            return password.Errors;
        }

        if (string.IsNullOrWhiteSpace(request.Code) || request.Code.Length < 6)
        {
            return Errors.ForgotPassword.ForgotTokenNotValid;
        }

        // validate code
        var forgotKey = new ForgotKey(request.Code);
        var forgotToken = await _keyValueRepository.GetAndDeleteAsync(forgotKey);

        if (forgotToken is null)
        {
            return Errors.ForgotPassword.ForgotTokenNotValid;
        }

        if (!await _jwtProvider.ValidateTokenAsync(forgotToken!, cancellationToken))
        {
            return Errors.ForgotPassword.ForgotTokenNotValid;
        }

        try
        {
            claims = await _jwtProvider.GetClaims(forgotToken!);
        }
        catch (SecurityTokenException)
        {
            return Errors.ForgotPassword.ForgotTokenNotValid;
        }

        email = Email.Create(claims[UserClaims.Email]);

        if (email.IsError)
        {
            return email.Errors;
        }

        // get user by token
        var auth = await _authRepository.GetAuthByEmail(email.Value, cancellationToken);

        if (auth is null)
        {
            return Errors.User.EmailDoesNotExists;
        }

        var hashedPassword = Password.FromHash(_passwordProvider.HashPassword(password.Value));
        await _authRepository.UpdateUserPassword(auth.Id, hashedPassword, cancellationToken);

        return "Password alterada com sucesso.";
    }
}