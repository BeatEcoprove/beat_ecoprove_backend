using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;

internal sealed class SignInEnterpriseAccountCommandHandler : ICommandHandler<SignInEnterpriseAccountCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IAuthRepository _authRepository;
    private readonly IProfileRepository _profileRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtProvider _jwtProvider;
    private readonly IAccountService _accountService;

    public SignInEnterpriseAccountCommandHandler(
        IAuthRepository authRepository,
        IProfileRepository profileRepository,
        IUnitOfWork unitOfWork,
        IJwtProvider jwtProvider,
        IAccountService accountService)
    {
        _authRepository = authRepository;
        _profileRepository = profileRepository;
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
        _accountService = accountService;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(SignInEnterpriseAccountCommand request, CancellationToken cancellationToken = default)
    {
        var userName = UserName.Create(request.UserName);
        var email = Email.Create(request.Email);
        var phone = Phone.Create(request.CountryCode, request.Phone);
        var password = Password.Create(request.Password);
        var postalCode = PostalCode.Create(request.PostalCode);

        var result = ValidateConstraints(email, phone, password, postalCode);

        if (result.IsError)
        {
            return result.Errors;
        }

        var address = Address.Create(request.Street, request.Port, request.Locality, postalCode.Value);

        if (address.IsError)
        {
            return address.Errors;
        }

        // Check if user exists
        if (await _authRepository.ExistsUserByEmailAsync(email.Value, cancellationToken))
        {
            return Errors.User.EmailAlreadyExists;
        }

        // Check if user ename already exists
        if (await _profileRepository.ExistsUserByUserNameAsync(userName, cancellationToken))
        {
            return Errors.User.UserNameAlreadyExists;
        }

        var enterpriseAccount = Organization.Create(
            userName,
            phone.Value,
            address.Value
        );
        
        var account = await _accountService.CreateAccount(
            email.Value, 
            password.Value, 
            enterpriseAccount, 
            request.AvatarPicture, 
            cancellationToken);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var payload = new AuthTokenPayload(
            account.Id,
            account.Email,
            enterpriseAccount.UserName,
            enterpriseAccount.AvatarUrl,
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

    private static ErrorOr<Email> ValidateConstraints(ErrorOr<Email> email, ErrorOr<Phone> phone, ErrorOr<Password> password, ErrorOr<PostalCode> postalCode)
    {
        return email
            .AddValidate(phone)
            .AddValidate(password)
            .AddValidate(postalCode);
    }
}