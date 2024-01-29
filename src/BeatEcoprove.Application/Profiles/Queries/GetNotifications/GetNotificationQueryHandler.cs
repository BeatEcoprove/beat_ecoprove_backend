using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.Documents;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;
using MongoDB.Driver;

namespace BeatEcoprove.Application.Profiles.Queries.GetNotifications;

internal sealed class GetNotificationQueryHandler : IQueryHandler<GetNotificationQuery, ErrorOr<List<Notification>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IMongoCollection<Notification> _mongoCollection;

    public GetNotificationQueryHandler(
        IProfileManager profileManager,
        IMongoDatabase mongoDatabase)
    {
        _profileManager = profileManager;
        _mongoCollection = mongoDatabase.GetCollection<Notification>("notifications");
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
        
        var filter = Builders<Notification>.Filter.Eq("UserId", profile.Value.Id.Value.ToString());
        
        var result = await _mongoCollection
            .Find(filter)
            .ToListAsync(cancellationToken);

        return result;
    }
}