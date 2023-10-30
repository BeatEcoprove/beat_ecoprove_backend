using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using ErrorOr;
using Microsoft.IdentityModel.Tokens;

namespace BeatEcoprove.Application;

public class ResetPasswordCommandHandler : ICommandHandler<ResetPasswordCommand, ErrorOr<string>>
{
    private readonly IJwtProvider _jwtProvider;
    private readonly IUserRepository _userRepository;
    private readonly IPasswordProvider _passwordProvider;

    public ResetPasswordCommandHandler(
        IJwtProvider jwtProvider,
        IUserRepository userRepository,
        IPasswordProvider passwordProvider)
    {
        _jwtProvider = jwtProvider;
        _userRepository = userRepository;
        _passwordProvider = passwordProvider;
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

        if (!await _jwtProvider.ValidateToken(request.ForgotToken))
        {
            return Errors.ForgotPassword.ForgotTokenNotValid;
        }

        try
        {
            claims = await _jwtProvider.GetClaims(request.ForgotToken);
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
        var user = await _userRepository.GetUserByEmail(email.Value, cancellationToken);

        if (user is null)
        {
            return Errors.User.EmailDoesNotExists;
        }

        var hashedPassword = Password.FromHash(_passwordProvider.HashPassword(password.Value));
        await _userRepository.UpdateUserPassword(user.Id, hashedPassword, cancellationToken);

        return "Password alterada com sucesso.";
    }
}
