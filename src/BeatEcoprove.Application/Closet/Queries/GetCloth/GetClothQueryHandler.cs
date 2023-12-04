using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Queries.GetCloth;

internal sealed class GetClothQueryHandler : IQueryHandler<GetClothQuery, ErrorOr<ClothResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;

    public GetClothQueryHandler(
        IProfileManager profileManager, 
        IClosetService closetService)
    {
        _profileManager = profileManager;
        _closetService = closetService;
    }

    public async Task<ErrorOr<ClothResult>> Handle(GetClothQuery request, CancellationToken cancellationToken)
    {
        var clothId = ClothId.Create(request.ClothId);
        
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var clothResult = await _closetService.GetClothResult(profile.Value, clothId, cancellationToken);

        return clothResult;
    }
}