using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
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
    private readonly IPasswordProvider _passwordProvider;
    private readonly IFileStorageProvider _fileStorageProvider;

    public SignInPersonalAccountCommandHandler(
        IAuthRepository authRepository,
        IProfileRepository profileRepository,
        IUnitOfWork unitOfWork,
        IJwtProvider jwtProvider,
        IPasswordProvider passwordProvider, 
        IFileStorageProvider fileStorageProvider)
    {
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
        _authRepository = authRepository;
        _profileRepository = profileRepository;
        _passwordProvider = passwordProvider;
        _fileStorageProvider = fileStorageProvider;
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
        if (await _authRepository.ExistsUserByEmailAsync(email.Value, cancellationToken))
        {
            return Errors.User.EmailAlreadyExists;
        }

        // Check if user exists
        if (await _profileRepository.ExistsUserByUserNameAsync(userName, cancellationToken))
        {
            return Errors.User.UserNameAlreadyExists;
        }

        var passwordHash = Password.FromHash(_passwordProvider.HashPassword(password.Value));

        // Create User
        var account = Auth.Create(
            email.Value,
            passwordHash);

        var avatarUrl = 
            await _fileStorageProvider
                .UploadFileAsync(
                    Buckets.ProfileBucket, 
                    account.Id.Value.ToString()!, 
                    request.AvatarPicture, 
                    cancellationToken);
        
        var personalProfile = Consumer.Create(
                account.Id,
                userName,
                phone.Value,
                avatarUrl,
                request.BornDate,
                gender
        );

        await _authRepository.AddAsync(account, cancellationToken);
        await _profileRepository.AddAsync(personalProfile, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var payload = new AuthTokenPayload(
            personalProfile.Id,
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