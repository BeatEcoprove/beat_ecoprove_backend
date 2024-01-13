using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Commands.DeleteNestedProfile;

internal sealed class DeleteNestedProfileCommandHandler : ICommandHandler<DeleteNestedProfileCommand, ErrorOr<Profile>>
{
    private readonly IProfileManager _profileManager;
    private readonly IProfileRepository _profileRepository;
    private readonly IUnitOfWork _unitOfWork;
    
    public DeleteNestedProfileCommandHandler(
        IProfileManager profileManager, 
        IProfileRepository profileRepository, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _profileRepository = profileRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<ErrorOr<Profile>> Handle(DeleteNestedProfileCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);
        
        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        // delete the profile and save changes
        await _profileRepository.DeleteAsync(profile.Value.Id, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return profile;
    }
}