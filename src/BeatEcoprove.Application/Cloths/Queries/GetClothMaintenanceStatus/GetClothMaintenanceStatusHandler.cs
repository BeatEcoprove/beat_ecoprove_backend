using BeatEcoprove.Application.Cloths.Queries.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Queries.GetClothMaintenanceStatus;

internal sealed class GetClothMaintenanceStatusHandler : IQueryHandler<GetClothMaintenanceStatusQuery, ErrorOr<ClothMaintenanceStatus>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IClothRepository _clothRepository;
    private readonly IMaintenanceServiceRepository _maintenanceServiceRepository;

    public GetClothMaintenanceStatusHandler(
        IProfileManager profileManager,
        IClosetService closetService,
        IClothRepository clothRepository,
        IMaintenanceServiceRepository maintenanceServiceRepository)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _clothRepository = clothRepository;
        _maintenanceServiceRepository = maintenanceServiceRepository;
    }

    public async Task<ErrorOr<ClothMaintenanceStatus>> Handle(GetClothMaintenanceStatusQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var clothId = ClothId.Create(request.ClothId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var cloth = await _closetService.GetClothResult(profile.Value, clothId, cancellationToken: cancellationToken);

        if (cloth.IsError)
        {
            return cloth.Errors;
        }

        var activity = await _clothRepository.GetLatestMaintenanceActivity(clothId, cancellationToken);

        if (activity is null)
        {
            return Errors.Cloth.MaintenanceActivityNotFound;
        }

        var service = await _maintenanceServiceRepository.GetByIdAsync(activity.ServiceId, cancellationToken);

        if (service is null)
        {
            return Errors.MaintenanceService.NotFound;
        }

        var action = await _maintenanceServiceRepository.GetActionByIdAsync(activity.ActionId, cancellationToken);

        if (action is null)
        {
            return Errors.MaintenanceService.NotFoundAction;
        }

        return new ClothMaintenanceStatus(
            cloth.Value,
            service,
            action,
            activity.Id.Value,
            activity.IsRunning() ? "Running" : "Finished");
    }
}