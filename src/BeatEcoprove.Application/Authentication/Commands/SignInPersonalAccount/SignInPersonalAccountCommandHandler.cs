using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;

internal sealed class SignInPersonalAccountCommandHandler : ICommandHandler<SignInPersonalAccountCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IAuthRepository _authRepository;
    private readonly IProfileRepository _profileRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtProvider _jwtProvider;
    private readonly IAccountService _accountService;

    public SignInPersonalAccountCommandHandler(
        IAuthRepository authRepository,
        IProfileRepository profileRepository,
        IUnitOfWork unitOfWork,
        IJwtProvider jwtProvider, 
        IAccountService accountService)
    {
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
        _accountService = accountService;
        _authRepository = authRepository;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(SignInPersonalAccountCommand request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);
        var password = Password.Create(request.Password);
        var phone = Phone.Create(request.CountryCode, request.Phone);
        var userName = UserName.Create(request.UserName);
        var gender = _accountService.GetGender(request.Gender);

        var shouldBeValid = ValidateConstraints(email, password, phone, gender);

        if (shouldBeValid.IsError)
        {
            return shouldBeValid.Errors;
        }

        // Check if user exists
        if (await _authRepository.ExistsUserByEmailAsync(email.Value, cancellationToken))
        {
            return Errors.User.EmailAlreadyExists;
        }

        // Check if user exists
        if (await _profileRepository.ExistsUserByUserNameAsync(userName, cancellationToken))
        {
            return Errors.User.UserNameAlreadyExists;
        }
        
        var personalProfile = Consumer.Create(
                userName,
                phone.Value,
                request.BornDate,
                gender.Value
        );

        var account = await _accountService.CreateAccount(
            email.Value,
            password.Value,
            personalProfile,
            request.AvatarPicture,
            cancellationToken
        );

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var payload = new AuthTokenPayload(
            account.Id,
            account.Email,
            personalProfile.UserName,
            personalProfile.AvatarUrl,
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

    private ErrorOr<Email> ValidateConstraints(
        ErrorOr<Email> email, 
        ErrorOr<Password> password, 
        ErrorOr<Phone> phone, 
        ErrorOr<Gender> gender)
    {
        return email
            .AddValidate(password)
            .AddValidate(phone)
            .AddValidate(gender);
    }
}