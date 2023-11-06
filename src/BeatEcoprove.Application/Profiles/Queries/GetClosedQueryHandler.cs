using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClothAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries;

internal sealed class GetClosedQueryHandler : IQueryHandler<GetClosetQuery, ErrorOr<List<Cloth>>>
{
    private readonly IAuthorizationFacade _authorizationFacade;
    private readonly IClothRepository _clothRepository;

    public GetClosedQueryHandler(
        IAuthorizationFacade authorizationFacade,
        IClothRepository clothRepository)
    {
        _authorizationFacade = authorizationFacade;
        _clothRepository = clothRepository;
    }

    public async Task<ErrorOr<List<Cloth>>> Handle(GetClosetQuery request, CancellationToken cancellationToken)
    {
        var profile = await _authorizationFacade.GetAuthProfileByEmailAsync(request.UserEmail, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        return await _clothRepository.GetAllClothAndBuckets(profile.Value.Id, cancellationToken);
    }
}