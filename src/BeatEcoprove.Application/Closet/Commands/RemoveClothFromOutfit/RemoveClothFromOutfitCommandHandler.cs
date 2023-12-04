using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.RemoveClothFromOutfit;

internal sealed class RemoveClothFromOutfitCommandHandler : ICommandHandler<RemoveClothFromOutfitCommand, ErrorOr<DailyUseActivity>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IActivityRepository _activityRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoveClothFromOutfitCommandHandler(
        IProfileManager profileManager, 
        IClosetService closetService, 
        IActivityRepository activityRepository, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _activityRepository = activityRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<DailyUseActivity>> Handle(RemoveClothFromOutfitCommand request, CancellationToken cancellationToken)
    {
        var clothId = ClothId.Create(request.ClothId);
        
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var cloth = await _closetService.GetCloth(profile.Value, clothId, cancellationToken);

        if (cloth.IsError)
        {
            return cloth.Errors;
        }
        
        var activity = await _activityRepository.GetLastDailyUseActivityAsync(profile.Value, clothId, cancellationToken);

        if (activity is null)
        {
            return Errors.Cloth.CannotDisposeCloth;
        }
        
        var shouldDisposeCloth = cloth.Value.DisposeCloth(activity);

        if (shouldDisposeCloth.IsError)
        {
            return shouldDisposeCloth.Errors;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return activity;
    }
}