﻿using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class ClothRepository : Repository<Cloth, ClothId>, IClothRepository
{
    public ClothRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<ClothDao?> GetClothDaoByIdAsync(ClothId id, CancellationToken cancellationToken = default)
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
                cloth.State.ToString(),
                cloth.ClothAvatar
            );
        
        return await getCloth.SingleOrDefaultAsync(cancellationToken);
    }

    public async Task RemoveByIdAsync(ClothId clothId, CancellationToken cancellationToken)
    {
        var cloth = await DbContext
            .Cloths
            .SingleOrDefaultAsync(cloth => cloth.Id == clothId, cancellationToken);

        if (cloth is null)
        {
            throw new Exception("Cloth not found");
        }

        DbContext.Cloths.Remove(cloth);
    }
    
    public async Task<List<MaintenanceService>> GetAvailableMaintenanceServices(ClothId id, CancellationToken cancellationToken)
    {
        var getAvailableServices =
            from services in DbContext.Set<MaintenanceService>()
            where (
                from cloth in DbContext.Cloths
                from mainActivity in DbContext.Set<MaintenanceActivity>()
                where mainActivity.ClothId == cloth.Id && cloth.Id == id && mainActivity.EndAt < DateTime.UtcNow
                select mainActivity).FirstOrDefault() != null
            select services;
        
        return await getAvailableServices.ToListAsync(cancellationToken);
    }

    public async Task<bool> ClothExists(List<ClothId> cloths, CancellationToken cancellationToken = default)
    {
        return await DbContext.Cloths
            .AnyAsync(cloth => cloths.Contains(cloth.Id), cancellationToken);
    }
}