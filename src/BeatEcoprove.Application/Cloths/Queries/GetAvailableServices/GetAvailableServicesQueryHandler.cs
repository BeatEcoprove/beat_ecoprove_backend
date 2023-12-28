using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Cloths.Queries.GetAvailableServices;

internal sealed class GetAvailableServicesQueryHandler : IQueryHandler<GetAvailableServicesQuery, ErrorOr<List<MaintenanceService>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IClothRepository  _clothRepository;

    public GetAvailableServicesQueryHandler(
        IProfileManager profileManager, 
        IClosetService closetService, 
        IClothRepository clothRepository)
    {
        _profileManager = profileManager;
        _closetService = closetService;
        _clothRepository = clothRepository;
    }

    public async Task<ErrorOr<List<MaintenanceService>>> Handle(GetAvailableServicesQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var clothId = ClothId.Create(request.ClothId);
        
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var cloth = await _closetService.GetCloth(profile.Value, clothId, cancellationToken);
        
        if (cloth.IsError)
        {
            return cloth.Errors;
        }
        
        return await _clothRepository.GetAvailableMaintenanceServices(cloth.Value.Id, cancellationToken);
    }
}