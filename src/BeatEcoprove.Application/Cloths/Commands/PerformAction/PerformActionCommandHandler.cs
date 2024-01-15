using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Commands.PerformAction;

internal sealed class PerformActionCommandHandler : ICommandHandler<PerformActionCommand, ErrorOr<ClothResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IMaintenanceServiceRepository _maintenanceServiceRepository;
    private readonly IClosetService _closetService;
    private readonly IActivityRepository _activityRepository;
    private readonly IUnitOfWork _unitOfWork;

    public PerformActionCommandHandler(
        IProfileManager profileManager, 
        IMaintenanceServiceRepository maintenanceServiceRepository, 
        IClosetService closetService, 
        IActivityRepository activityRepository, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _maintenanceServiceRepository = maintenanceServiceRepository;
        _closetService = closetService;
        _activityRepository = activityRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<ClothResult>> Handle(PerformActionCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var clothId = ClothId.Create(request.ClothId);
        var serviceId = MaintenanceServiceId.Create(request.ServiceId);
        var actionId = MaintenanceActionId.Create(request.ActionId);
        
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        // Verify if MainService and action are exists
        if (!await _maintenanceServiceRepository.ExistServiceByIdAsync(serviceId, cancellationToken))
        {
            return Errors.MaintenanceService.NotFound;
        }
        
        var action = await _maintenanceServiceRepository.GetActionByIdAsync(actionId, cancellationToken);
        
        if (action is null)
        {
            return Errors.MaintenanceService.NotFoundAction;
        }
        
        // Verify if the service is available for the cloth
        var cloth = await _closetService.GetCloth(profile.Value, clothId, cancellationToken);
        
        if (cloth.IsError)
        {
            return cloth.Errors;
        }
        
        // Init Main Activity
        var activity = MaintenanceActivity.Create(
            serviceId,
            actionId,
            profile.Value.Id,
            cloth.Value.Id,
            action.SustainablePoints
        );
        
        // Perform the action
        var maintainCloth = cloth.Value.MaintainCloth(activity, action, profile.Value);
        
        if (maintainCloth.IsError)
        {
            return maintainCloth.Errors;
        }
        
        await _activityRepository.AddAsync(activity, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return (await _closetService.GetClothResult(profile.Value, clothId, cancellationToken)).Value;
    }
}