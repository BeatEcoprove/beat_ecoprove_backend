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
    private readonly IAuthRepository _authRepository;
    private readonly IMailSender _mailSender;
    private readonly IKeyValueRepository<string> _keyValueRepository;
    private readonly IJwtProvider _jwtProvider;

    public ForgotPasswordCommandHandler(
        IAuthRepository authRepository,
        IMailSender mailSender, 
        IKeyValueRepository<string> keyValueRepository, 
        IJwtProvider jwtProvider)
    {
        _authRepository = authRepository;
        _mailSender = mailSender;
        _keyValueRepository = keyValueRepository;
        _jwtProvider = jwtProvider;
    }

    public async Task<ErrorOr<string>> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);

        var user = await _authRepository.GetAuthByEmail(email.Value, cancellationToken);

        if (user is null)
        {
            return Errors.User.EmailDoesNotExists;
        }
        
        var generatedCode = _jwtProvider.GenerateRandomCode(6);

        var payload = new ForgotTokenPayload(
            email.Value,
            DateTime.Now.AddMinutes(10)
        );
        
        var forgotToken = _jwtProvider.GenerateToken(payload);

        var forgotKey = new ForgotKey(generatedCode);
        await _keyValueRepository.AddAsync(forgotKey, forgotToken, TimeSpan.FromMinutes(15));

        await _mailSender.SendMailAsync(
            user.Email.Value,
            "Forgot password",
            $"Your forgot password token is: {generatedCode}"
        );

        return "Email sent";
    }
}
