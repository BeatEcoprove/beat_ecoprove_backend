using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class ColorRepository : Repository<Color, ColorId>, IColorRepository
{
    public ColorRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public Task<ColorId?> GetByHexValueAsync(string hexValue, CancellationToken cancellationToken = default)
    {
        return DbContext
            .Set<Color>()
            .SingleOrDefaultAsync(e => e.Hex == hexValue, cancellationToken)
            .ContinueWith(t => t.Result?.Id, cancellationToken);
    }
}
