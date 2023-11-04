using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.ProfileAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
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
    private readonly IPasswordProvider _passwordProvider;

    public SignInEnterpriseAccountCommandHandler(
        IAuthRepository authRepository,
        IProfileRepository profileRepository,
        IUnitOfWork unitOfWork,
        IJwtProvider jwtProvider,
        IPasswordProvider passwordProvider)
    {
        _authRepository = authRepository;
        _profileRepository = profileRepository;
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
        _passwordProvider = passwordProvider;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(SignInEnterpriseAccountCommand request, CancellationToken cancellationToken)
    {
        var userName = UserName.Create(request.UserName);
        var email = Email.Create(request.Email);
        var phone = Phone.Create(request.CountryCode, request.Phone);
        var password = Password.Create(request.Password);
        var postalCode = PostalCode.Create(request.PostalCode);

        var result = ValidateValues(email, phone, password, postalCode);

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

        var passwordHash = Password.FromHash(_passwordProvider.HashPassword(password.Value));

        var account = Auth.Create(
            email.Value,
            passwordHash);

        var enterpriseAccount = Organization.Create(
            account.Id,
            userName,
            phone.Value,
            "https://github.com/DiogoCC7.png",
            address.Value
        );

        // Persist User
        await _authRepository.AddAsync(account, cancellationToken);
        await _profileRepository.AddAsync(enterpriseAccount, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var payload = new AuthTokenPayload(
            enterpriseAccount.Id,
            account.Email,
            enterpriseAccount.UserName,
            enterpriseAccount.AvatarUrl,
            10,
            10,
            10,
            Tokens.Access);

        // Generate Tokens
        var accessToken = _jwtProvider.GenerateToken(payload);

        payload.Type = Tokens.Refresh;
        var refreshToken = _jwtProvider.GenerateToken(payload);

        return new AuthenticationResult(
            accessToken,
            refreshToken);
    }

    private static ErrorOr<Email> ValidateValues(ErrorOr<Email> email, ErrorOr<Phone> phone, ErrorOr<Password> password, ErrorOr<PostalCode> postalCode)
    {
        return email
            .AddValidate(phone)
            .AddValidate(password)
            .AddValidate(postalCode);
    }
}