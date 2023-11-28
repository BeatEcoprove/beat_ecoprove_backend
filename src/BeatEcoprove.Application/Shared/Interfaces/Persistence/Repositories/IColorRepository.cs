using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IColorRepository : IRepository<Color, ColorId>
{
    Task<ColorId?> GetByHexValueAsync(string hexValue, CancellationToken cancellationToken = default);
}