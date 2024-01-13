using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.ForgotPassword;

internal sealed class ForgotPasswordCommandHandler : ICommandHandler<ForgotPasswordCommand, ErrorOr<string>>
{
    private readonly IJwtProvider _jwtProvider;
    private readonly IAuthRepository _authRepository;
    private readonly IMailSender _mailSender;

    public ForgotPasswordCommandHandler(
        IJwtProvider jwtProvider,
        IAuthRepository authRepository,
        IMailSender mailSender)
    {
        _jwtProvider = jwtProvider;
        _authRepository = authRepository;
        _mailSender = mailSender;
    }

    public async Task<ErrorOr<string>> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);

        // get user by email
        var user = await _authRepository.GetAuthByEmail(email.Value, cancellationToken);

        if (user is null)
        {
            return Errors.User.EmailDoesNotExists;
        }

        // create token payload idictionary
        var payload = new ForgotTokenPayload(
            email.Value,
            DateTime.Now.AddMinutes(10) // 10 minutes
        );

        var forgotToken = _jwtProvider.GenerateToken(payload);

        // send email with token
        await _mailSender.SendMailAsync(
            user.Email.Value,
            "Forgot password",
            $"Your forgot password token is: {forgotToken}"
        );

        return "Email sent";
    }
}
