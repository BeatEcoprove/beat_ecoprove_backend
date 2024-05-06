using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Extensions;

using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;

internal sealed class SignInEnterpriseAccountCommandHandler : ICommandHandler<SignInEnterpriseAccountCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtProvider _jwtProvider;
    private readonly IAccountService _accountService;

    public SignInEnterpriseAccountCommandHandler(
        IUnitOfWork unitOfWork,
        IJwtProvider jwtProvider,
        IAccountService accountService)
    {
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
        _accountService = accountService;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(SignInEnterpriseAccountCommand request, CancellationToken cancellationToken = default)
    {
        var userName = UserName.Create(request.UserName.Capitalize());
        var email = Email.Create(request.Email);
        var phone = Phone.Create(request.CountryCode, request.Phone);
        var password = Password.Create(request.Password);
        var postalCode = PostalCode.Create(request.PostalCode);

        var result = ValidateConstraints(email, phone, password, postalCode, userName);

        if (result.IsError)
        {
            return result.Errors;
        }

        var address = Address.Create(request.Street, request.Port, request.Locality, postalCode.Value);

        if (address.IsError)
        {
            return address.Errors;
        }

        var enterpriseProfile = Organization.Create(
            userName.Value,
            phone.Value,
            address.Value
        );

        var account = await _accountService.CreateAccount(
            email.Value,
            password.Value,
            enterpriseProfile,
            request.AvatarPicture,
            cancellationToken);

        if (account.IsError)
        {
            return account.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var (accessToken, refreshToken) =
            _jwtProvider
                .GenerateAuthenticationTokens(account.Value, enterpriseProfile, enterpriseProfile.Id);

        return new AuthenticationResult(
            accessToken,
            refreshToken);
    }

    private static ErrorOr<Email> ValidateConstraints(ErrorOr<Email> email, ErrorOr<Phone> phone,
        ErrorOr<Password> password, ErrorOr<PostalCode> postalCode, ErrorOr<UserName> userName)
    {
        return email
            .AddValidate(phone)
            .AddValidate(password)
            .AddValidate(postalCode)
            .AddValidate(userName);
    }
}