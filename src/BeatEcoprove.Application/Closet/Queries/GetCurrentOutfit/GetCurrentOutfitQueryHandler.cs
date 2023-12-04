using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using ErrorOr;
using Mapster;

namespace BeatEcoprove.Application.Closet.Queries.GetCurrentOutfit;

internal sealed class GetCurrentOutfitQueryHandler : IQueryHandler<GetCurrentOutfitQuery, ErrorOr<List<ClothResult>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IActivityRepository _activityRepository;

    public GetCurrentOutfitQueryHandler(
        IProfileManager profileManager, 
        IActivityRepository activityRepository)
    {
        _profileManager = profileManager;
        _activityRepository = activityRepository;
    }

    public async Task<ErrorOr<List<ClothResult>>> Handle(GetCurrentOutfitQuery request, CancellationToken cancellationToken)
    {
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var outfit = await _activityRepository.GetCurrentOutfitAsync(profile.Value.Id, cancellationToken);

        return outfit.Select(cloth => cloth.Adapt<ClothResult>()).ToList();
    }
}