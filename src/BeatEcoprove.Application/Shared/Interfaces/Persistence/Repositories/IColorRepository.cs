using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IColorRepository : IRepository<Color, ColorId>
{
    Task<ColorId?> GetByHexValueAsync(string hexValue, CancellationToken cancellationToken = default);
}