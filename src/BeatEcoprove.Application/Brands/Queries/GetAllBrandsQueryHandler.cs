using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.Shared.Entities;
using ErrorOr;

namespace BeatEcoprove.Application.Brands.Queries;

internal sealed class GetAllBrandsQueryHandler : IQueryHandler<GetAllBrandsQuery, ErrorOr<List<Brand>>>
{
    private readonly IBrandRepository _brandRepository;

    public GetAllBrandsQueryHandler(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task<ErrorOr<List<Brand>>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
    {
        return await _brandRepository.GetAllAsync(cancellationToken);
    }
}