using BeatEcoprove.Application;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Infrastructure.Extensions;
using ErrorOr;

namespace BeatEcoprove.Infrastructure.Services;

public class AccountService : IAccountService
{
    private readonly IAuthRepository _authRepository;
    private readonly IProfileRepository _profileRepository;
    private readonly IFileStorageProvider _fileProvider;
    private readonly IPasswordProvider _passwordProvider;

    public AccountService(
        IAuthRepository authRepository, 
        IProfileRepository profileRepository, 
        IFileStorageProvider fileProvider, 
        IPasswordProvider passwordProvider)
    {
        _authRepository = authRepository;
        _profileRepository = profileRepository;
        _fileProvider = fileProvider;
        _passwordProvider = passwordProvider;
    }

    public async Task<Auth> CreateAccount(
        Email email, 
        Password password, 
        Profile profile, 
        Stream avatarStream, 
        CancellationToken cancellationToken = default)
    {
        var passwordHash = Password.FromHash(_passwordProvider.HashPassword(password.Value));
        
        var auth = Auth.Create
        (
            email,
            passwordHash
        );
        
        profile.SetAuthPointer(auth.Id);
        auth.SetMainProfileId(profile.Id);
        
        var avatarUrl = 
            await _fileProvider
                .UploadFileAsync(
                    Buckets.ProfileBucket,
                    ((Guid)profile.Id).ToString(), 
                    avatarStream, 
                    cancellationToken);
        
        profile.SetProfileAvatar(avatarUrl);
        
        await _authRepository.AddAsync(auth, cancellationToken);
        await _profileRepository.AddAsync(profile, cancellationToken);

        return auth;
    }

    public ErrorOr<Gender> GetGender(string gender)
    {
        if (gender.CanConvertToEnum(out Gender result))
        {
            return result;
        }

        return Errors.User.InvalidUserGender;
    }
}