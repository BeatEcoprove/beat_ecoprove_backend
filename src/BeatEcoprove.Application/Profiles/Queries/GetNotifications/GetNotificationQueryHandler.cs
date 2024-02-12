using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetNotifications;

internal sealed class GetNotificationQueryHandler : IQueryHandler<GetNotificationQuery, ErrorOr<List<Notification>>>
{
    private readonly IProfileManager _profileManager;
    private readonly INotificationRepository _notificationRepository;

    public GetNotificationQueryHandler(
        IProfileManager profileManager, 
        INotificationRepository notificationRepository)
    {
        _profileManager = profileManager;
        _notificationRepository = notificationRepository;
    }

    public async Task<ErrorOr<List<Notification>>> Handle(GetNotificationQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        return await _notificationRepository
            .GetAllNotificationByOnwerIdAsync(profile.Value.Id, cancellationToken);
    }
}