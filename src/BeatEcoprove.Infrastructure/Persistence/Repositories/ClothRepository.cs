using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class ClothRepository : Repository<Cloth, ClothId>, IClothRepository
{
    public ClothRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Cloth>> GetClothOfProfile(ProfileId profileId, CancellationToken cancellationToken = default)
    {
        return await
            DbContext.Profiles
                .Include(profile => profile.ClothEntries)
                .Where(profile => profile.Id == profileId)
                .SelectMany(profile => profile.ClothEntries)
                .Join(DbContext.Cloths,
                    clothEntry => clothEntry.ClothId,
                    cloth => cloth.Id,
                    (clothEntry, cloth) => cloth)
                .ToListAsync(cancellationToken);
    }

    public new async Task<ClothDao?> GetByIdAsync(ClothId id, CancellationToken cancellationToken = default)
    {
        var getCloth = 
            from cloth in DbContext.Cloths
            from color in DbContext.Set<Color>()
            from brand in DbContext.Set<Brand>()
            where cloth.Id == id && cloth.Color == color.Id && cloth.Brand == brand.Id
            select new ClothDao
            (
               cloth.Id,
               cloth.Name,
                cloth.Type.ToString(),
                cloth.Size.ToString(),
                brand.Name,
                color.Hex,
                cloth.EcoScore,
               cloth.ClothAvatar
            );
        
        return await getCloth.SingleOrDefaultAsync(cancellationToken);
    }

    public async Task<bool> ClothExists(List<ClothId> cloths, CancellationToken cancellationToken = default)
    {
        return await DbContext.Cloths
            .AnyAsync(cloth => cloths.Contains(cloth.Id), cancellationToken);
    }
}