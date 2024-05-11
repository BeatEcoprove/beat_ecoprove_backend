using BeatEcoprove.Application.Cloths.Queries.Common.HistoryResult;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Queries.GetHistory;

internal sealed class GetHistoryQueryHandler : IQueryHandler<GetHistoryQuery, ErrorOr<List<HistoryResult>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IClothRepository _clothRepository;
    private readonly IMaintenanceServiceRepository _maintenanceServiceRepository;
    private readonly ILanguageCulture _languageCulture;

    public GetHistoryQueryHandler(
        IProfileManager profileManager,
        IClosetService closetService,
        IClothRepository clothRepository,
        IMaintenanceServiceRepository maintenanceServiceRepository,
        ILanguageCulture languageCulture)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _clothRepository = clothRepository;
        _maintenanceServiceRepository = maintenanceServiceRepository;
        _languageCulture = languageCulture;
    }

    public async Task<ErrorOr<List<HistoryResult>>> Handle(GetHistoryQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var clothId = ClothId.Create(request.ClothId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var cloth = await _closetService.GetCloth(profile.Value, clothId, cancellationToken);

        if (cloth.IsError)
        {
            return cloth.Errors;
        }

        var history = await _clothRepository.GetHistoryOfActivities(clothId, cancellationToken);

        foreach (var activity in history)
        {

        }

        List<HistoryResult> historyActivities = history.Select(activity =>
        {
            ErrorOr<HistoryResult> task = activity switch
            {
                MaintenanceActivity maintenanceActivity => HandleMaintenaceActivity(maintenanceActivity, cancellationToken).GetAwaiter().GetResult(),
                DailyUseActivity dailyUseActivity => HandleDailyActivity(dailyUseActivity),
                _ => Errors.MaintenanceService.NotFound,
            };

            return task;
        })
        .Where(activity => !activity.IsError)
        .Select(activity => activity.Value)
        .ToList();

        return historyActivities;
    }

    private ErrorOr<HistoryResult> HandleDailyActivity(DailyUseActivity activity)
    {
        return new DailyHistoryResult(
            _languageCulture.GetChunk("DailyUse", "Piece was used on"),
            activity.EndAt ?? DateTimeOffset.UtcNow
        );
    }

    private async Task<ErrorOr<HistoryResult>> HandleMaintenaceActivity(MaintenanceActivity activity, CancellationToken cancellationToken = default)
    {
        var maintenaceId = MaintenanceServiceId.Create(activity.ServiceId);
        var actionId = MaintenanceActionId.Create(activity.ActionId);

        var maintenaceService = await _maintenanceServiceRepository.GetByIdAsync(maintenaceId, cancellationToken);

        if (maintenaceService is null)
        {
            return Errors.MaintenanceService.NotFound;
        }

        var action = await _maintenanceServiceRepository.GetActionByIdAsync(actionId, cancellationToken);

        if (action is null)
        {
            return Errors.MaintenanceService.NotFoundAction;
        }

        return new MaintenaceHistoryResult(
            maintenaceService.Title,
            action.Title,
            activity.EndAt ?? DateTimeOffset.UtcNow
        );


    }
}