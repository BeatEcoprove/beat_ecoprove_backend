using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Contracts.Profile;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Commands.CloseMaintenanceActivity;

internal sealed class CloseMaintenanceActivityCommandHandler : ICommandHandler<CloseMaintenanceActivityCommand, ErrorOr<ClothResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IActivityRepository _activityRepository;
    private readonly IMaintenanceServiceRepository _maintenanceServiceRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CloseMaintenanceActivityCommandHandler(
        IProfileManager profileManager, 
        IClosetService closetService, 
        IActivityRepository activityRepository, 
        IMaintenanceServiceRepository maintenanceServiceRepository, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _activityRepository = activityRepository;
        _maintenanceServiceRepository = maintenanceServiceRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<ClothResult>> Handle(CloseMaintenanceActivityCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var clothId = ClothId.Create(request.ClothId);
        var maintenanceActivityId = ActivityId.Create(request.MaintenanceActivityId);
        
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var activity = await _activityRepository.GetByIdAsync(maintenanceActivityId, cancellationToken) as MaintenanceActivity;
        
        if (activity is null)
        {
            return Errors.Cloth.CannotFinishMaintenanceActivity;
        }
        
        var action = await _maintenanceServiceRepository.GetActionByIdAsync(activity.ActionId, cancellationToken);
        
        if (action is null)
        {
            return Errors.MaintenanceService.NotFoundAction;
        }
        
        var cloth = await _closetService.GetCloth(profile.Value, clothId, cancellationToken);
        
        if (cloth.IsError)
        {
            return cloth.Errors;
        }
        
        var result = cloth.Value.CloseMaintenance(activity, action);
        
        if (result.IsError)
        {
            return result.Errors;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return (await _closetService.GetClothResult(profile.Value, clothId, cancellationToken)).Value;
    }
}