using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Extensions;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;

internal sealed class SignInPersonalAccountCommandHandler : ICommandHandler<SignInPersonalAccountCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtProvider _jwtProvider;
    private readonly IAccountService _accountService;

    public SignInPersonalAccountCommandHandler(
        IUnitOfWork unitOfWork,
        IJwtProvider jwtProvider, 
        IAccountService accountService)
    {
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
        _accountService = accountService;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(SignInPersonalAccountCommand request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);
        var password = Password.Create(request.Password);
        var phone = Phone.Create(request.CountryCode, request.Phone);
        var userName = UserName.Create(request.UserName.Capitalize());
        var gender = _accountService.GetGender(request.Gender);

        var shouldBeValid = ValidateConstraints(email, password, phone, gender);

        if (shouldBeValid.IsError)
        {
            return shouldBeValid.Errors;
        }
        
        var personalProfile = Consumer.Create(
                userName.Value,
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

        if (account.IsError)
        {
            return account.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var ( accessToken, refreshToken ) =
            _jwtProvider
                .GenerateAuthenticationTokens(account.Value, personalProfile);

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