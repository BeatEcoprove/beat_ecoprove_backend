using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IBrandRepository : IRepository<Brand, BrandId>
{
    Task<BrandId?> GetBrandIdByNameAsync(string name, CancellationToken cancellationToken = default);
}