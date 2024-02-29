using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

using Microsoft.EntityFrameworkCore;

namespace BeatEcoprove.Infrastructure.Persistence.Repositories;

public class BrandRepository : Repository<Brand, BrandId>, IBrandRepository
{
    public BrandRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Brand>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await DbContext.Set<Brand>().ToListAsync(cancellationToken);
    }

    public async Task<BrandId?> GetBrandIdByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<Brand>()
            .SingleOrDefaultAsync(brand => brand.Name == name, cancellationToken)
            .ContinueWith(task => task.Result?.Id, cancellationToken);
    }
}