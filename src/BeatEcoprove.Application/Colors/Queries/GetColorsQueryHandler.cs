using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.Shared.Entities;
using ErrorOr;

namespace BeatEcoprove.Application.Colors.Queries;

internal sealed class GetColorsQueryHandler : IQueryHandler<GetColorsQuery, ErrorOr<List<Color>>>
{
    private readonly IColorRepository _colorRepository;

    public GetColorsQueryHandler(IColorRepository colorRepository)
    {
        _colorRepository = colorRepository;
    }

    public async Task<ErrorOr<List<Color>>> Handle(GetColorsQuery request, CancellationToken cancellationToken)
    {
        return await _colorRepository.GetAllColors(cancellationToken);
    }
}