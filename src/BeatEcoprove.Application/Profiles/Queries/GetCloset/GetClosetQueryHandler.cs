using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClothAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetCloset;

internal sealed class GetClosetQueryHandler : IQueryHandler<GetClosetQuery, ErrorOr<List<Cloth>>>
{
    private readonly IAuthorizationFacade _authorizationFacade;
    private readonly IAuthRepository _authRepository;
    private readonly IClothRepository _clothRepository;

    public GetClosetQueryHandler(
        IAuthorizationFacade authorizationFacade,
        IClothRepository clothRepository, 
        IAuthRepository authRepository)
    {
        _authorizationFacade = authorizationFacade;
        _clothRepository = clothRepository;
        _authRepository = authRepository;
    }

    public async Task<ErrorOr<List<Cloth>>> Handle(GetClosetQuery request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);
        var currentProfile = ProfileId.Create(request.ProfileId);
        
        var profile = await _authorizationFacade.GetAuthProfileByEmailAsync(request.Email, cancellationToken);

        var validationResult = profile
            .AddValidate(email);
        
        if (validationResult.IsError)
        {
            return validationResult.Errors;
        }
        
        if (IsMainProfile(currentProfile, profile))
        {
            return await _clothRepository.GetAllCloth(currentProfile, cancellationToken);
        }
        
        return await _clothRepository.GetClothOfProfile(profile.Value.Id, cancellationToken);
    }

    private static bool IsMainProfile(ProfileId currentProfile, ErrorOr<Profile> profile)
    {
        return currentProfile == profile.Value.Id;
    }
}