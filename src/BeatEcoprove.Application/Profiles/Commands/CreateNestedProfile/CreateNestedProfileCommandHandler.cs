using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Commands.CreateNestedProfile;

internal sealed class CreateNestedProfileCommandHandler : ICommandHandler<CreateNestedProfileCommand, ErrorOr<Profile>>
{
    private readonly IProfileManager _profileManager;
    private readonly IAccountService _accountService;
    private readonly IProfileRepository _profileRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileStorageProvider _fileStorageProvider;

    public CreateNestedProfileCommandHandler(
        IProfileManager profileManager, 
        IAccountService accountService,
        IProfileRepository profileRepository, 
        IUnitOfWork unitOfWork, 
        IFileStorageProvider fileStorageProvider)
    {
        _profileManager = profileManager;
        _accountService = accountService;
        _profileRepository = profileRepository;
        _unitOfWork = unitOfWork;
        _fileStorageProvider = fileStorageProvider;
    }

    public async Task<ErrorOr<Profile>> Handle(CreateNestedProfileCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        
        // Validate request
        var userName = UserName.Create(request.UserName.Capitalize());
        var gender = _accountService.GetGender(request.Gender);

        var shouldBeValid = userName.AddValidate(gender);

        if (shouldBeValid.IsError)
        {
            return shouldBeValid.Errors;
        }
        
        if (await _profileRepository.ExistsUserByUserNameAsync(userName.Value, cancellationToken))
        {
            return Errors.User.UserNameAlreadyExists;
        }
        
        // Get Main Profile and check profile
        var profile = await _profileManager.GetProfileAsync(authId, Guid.Empty, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
            
        // Create Nested Profile
        var phone = Phone.Create(profile.Value.Phone.Code, profile.Value.Phone.Value);
        
        var nestedProfile = Consumer.Create(
            userName.Value,
            phone.Value,
            request.BornDate,
            gender.Value
        );
        
        // Add Nested Profile to Main Profile
        nestedProfile.SetAuthPointer(profile.Value.AuthId);
        
        // Set avatar and store it on database
        var avatarUrl = 
            await _fileStorageProvider
                .UploadFileAsync(
                    Buckets.ProfileBucket,
                    ((Guid)nestedProfile.Id).ToString(), 
                    request.AvatarPicture, 
                    cancellationToken);
        
        nestedProfile.SetProfileAvatar(avatarUrl);
        
        // Save Nested Profile
        await _profileRepository.AddAsync(nestedProfile, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return nestedProfile;
    }
}