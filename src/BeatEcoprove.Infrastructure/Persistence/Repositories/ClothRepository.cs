using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClothAggregator;
using BeatEcoprove.Domain.ClothAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class ClothRepository : Repository<Cloth, ClothId>, IClothRepository
{
    public ClothRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Cloth>> GetAllClothAndBuckets(ProfileId profileId, CancellationToken cancellationToken = default)
    {
        return await
            DbContext.Profiles
                .Include(profile => profile.ClothEntries)
                .Where(profile => profile.Id == profileId)
                .SelectMany(profile => profile.ClothEntries)
                .Join(DbContext.Cloths,
                    clothEntry => clothEntry.Cloth,
                    cloth => cloth.Id,
                    (clothEntry, cloth) => cloth)
                .ToListAsync(cancellationToken);
    }
}