using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.RegisterClothUsage;

internal sealed class RegisterClothUsageCommandHandler : ICommandHandler<RegisterClothUsageCommand, ErrorOr<DailyUseActivity>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IActivityRepository _activityRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IClothRepository _clothRepository;

    public RegisterClothUsageCommandHandler(
        IProfileManager profileManager,
        IClosetService closetService,
        IActivityRepository activityRepository,
        IUnitOfWork unitOfWork,
        IClothRepository clothRepository)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _activityRepository = activityRepository;
        _unitOfWork = unitOfWork;
        _clothRepository = clothRepository;
    }

    public async Task<ErrorOr<DailyUseActivity>> Handle(RegisterClothUsageCommand request, CancellationToken cancellationToken)
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

        var services = await _clothRepository.GetAvailableMaintenanceServices(clothId, cancellationToken);

        if (services.Count == 0)
        {
            return Errors.Cloth.CannotUseClothBecauseIsOnMaintenance;
        }

        var activity = cloth.Value.UseCloth(profile.Value);

        if (activity.IsError)
        {
            return activity.Errors;
        }

        await _activityRepository.AddAsync(activity.Value, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return activity;
    }
}