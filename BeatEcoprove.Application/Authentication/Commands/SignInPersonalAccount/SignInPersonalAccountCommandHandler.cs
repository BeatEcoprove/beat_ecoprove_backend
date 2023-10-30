using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using BeatEcoprove.Domain.UserAggregator.Entities;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;

internal sealed class SignInPersonalAccountCommandHandler : ICommandHandler<SignInPersonalAccountCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtProvider _jwtProvider;
    private readonly IPasswordProvider _passwordProvider;

    public SignInPersonalAccountCommandHandler(
        IUserRepository userRepository,
        IUnitOfWork unitOfWork,
        IJwtProvider jwtProvider,
        IPasswordProvider passwordProvider)
    {
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
        _userRepository = userRepository;
        _passwordProvider = passwordProvider;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(SignInPersonalAccountCommand request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);
        var password = Password.Create(request.Password);
        var phone = Phone.Create(request.CountryCode, request.Phone);
        var userName = UserName.Create(request.UserName);
        var gender = Gender.Female;

        var result = ValidateValues(email, password, phone);

        if (result.IsError)
        {
            return result.Errors;
        }

        // Check if user exists
        if (await _userRepository.ExistsUserByEmailAsync(email.Value, cancellationToken))
        {
            return Errors.User.EmailAlreadyExists;
        }

        // Check if user exists
        if (await _userRepository.ExistsUserByUserNameAsync(userName, cancellationToken))
        {
            return Errors.User.UserNameAlreadyExists;
        }

        var passwordHash = Password.FromHash(_passwordProvider.HashPassword(password.Value));

        // Create User
        var personalAccount = Consumer.Create(
                email.Value,
                request.Name,
                passwordHash,
                phone.Value,
                "https://github.com/DiogoCC7.png",
                userName,
                gender,
                request.BornDate
            );

        // Persist User
        await _userRepository.AddAsync(personalAccount, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var payload = new AuthTokenPayload(
            personalAccount.Id,
            personalAccount.Email,
            personalAccount.Name,
            personalAccount.AvatarUrl,
            10,
            10,
            10,
            Tokens.Access);

        var accessToken = _jwtProvider.GenerateToken(payload);

        payload.Type = Tokens.Refresh;
        var refreshToken = _jwtProvider.GenerateToken(payload);

        // Return Tokens
        return new AuthenticationResult(
            accessToken,
            refreshToken);
    }

    private static ErrorOr<Email> ValidateValues(
        ErrorOr<Email> email,
        ErrorOr<Password> password,
        ErrorOr<Phone> phone)
    {
        return email
            .AddValidate(password)
            .AddValidate(phone);
    }
}