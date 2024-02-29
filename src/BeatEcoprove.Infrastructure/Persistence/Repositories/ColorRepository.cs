using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class ColorRepository : Repository<Color, ColorId>, IColorRepository
{
    public ColorRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Color>> GetAllColors(CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<Color>()
            .ToListAsync(cancellationToken);
    }

    public Task<ColorId?> GetByHexValueAsync(string hexValue, CancellationToken cancellationToken = default)
    {
        return DbContext
            .Set<Color>()
            .SingleOrDefaultAsync(e => e.Hex == hexValue, cancellationToken)
            .ContinueWith(t => t.Result?.Id, cancellationToken);
    }
}