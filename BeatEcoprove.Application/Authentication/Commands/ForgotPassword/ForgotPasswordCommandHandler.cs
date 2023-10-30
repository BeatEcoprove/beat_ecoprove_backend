using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using ErrorOr;
using MediatR;

namespace BeatEcoprove.Application;

public class ForgotPasswordCommandHandler : ICommandHandler<ForgotPasswordCommand, ErrorOr<string>>
{
    private readonly IJwtProvider _jwtProvider;
    private readonly IUserRepository _userRepository;
    private readonly IMailSender _mailSender;

    public ForgotPasswordCommandHandler(
        IJwtProvider jwtProvider,
        IUserRepository userRepository,
        IMailSender mailSender)
    {
        _jwtProvider = jwtProvider;
        _userRepository = userRepository;
        _mailSender = mailSender;
    }

    public async Task<ErrorOr<string>> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);

        // get user by email
        var user = await _userRepository.GetUserByEmail(email.Value, cancellationToken);

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
