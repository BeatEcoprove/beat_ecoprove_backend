using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IActivityRepository : IRepository<Activity, ActivityId>
{
    Task<DailyUseActivity?> GetLastDailyUseActivityAsync(Profile profile, ClothId clothId, CancellationToken cancellationToken);
    Task<List<ClothDao>> GetCurrentOutfitAsync(ProfileId profileId, CancellationToken cancellationToken);
}