using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class ActivityRepository : Repository<Activity, ActivityId>, IActivityRepository 
{
    public ActivityRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public Task<DailyUseActivity?> GetLastDailyUseActivityAsync(Profile profile, ClothId clothId, CancellationToken cancellationToken)
    {
        var getLastDailyUseActivityAsync =
            from activity in DbContext.Set<Activity>()
            from dailyUseActivity in DbContext.Set<DailyUseActivity>()
            where activity.Id == dailyUseActivity.Id
                  && activity.ProfileId == profile.Id
                  && dailyUseActivity.ClothId == clothId
                  orderby activity.CreatedAt descending 
            select dailyUseActivity;
        
        return getLastDailyUseActivityAsync.FirstOrDefaultAsync(cancellationToken);
    }

    public Task<List<ClothDao>> GetCurrentOutfitAsync(ProfileId profileId, CancellationToken cancellationToken)
    {
        var getCurrentOutfit =
            from activity in DbContext.Set<Activity>()
            join dailyUseActivity in DbContext.Set<DailyUseActivity>() on activity.Id equals dailyUseActivity.Id
            join cloth in DbContext.Set<Cloth>() on dailyUseActivity.ClothId equals cloth.Id
            join brand in DbContext.Set<Brand>() on cloth.Brand equals brand.Id
            join color in DbContext.Set<Color>() on cloth.Color equals color.Id
            where activity.ProfileId == profileId
            where dailyUseActivity.EndAt == default
            select new ClothDao
            (
                cloth.Id,
                cloth.Name,
                cloth.Type.ToString(),
                cloth.Size.ToString(),
                brand.Name,
                color.Hex,
                cloth.EcoScore,
                cloth.State.ToString(),
                cloth.ClothAvatar
            );
            
        return getCurrentOutfit.ToListAsync(cancellationToken);
    }
}