using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Extensions;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Queries.GetCloset;

internal sealed class GetClosetQueryHandler : IQueryHandler<GetClosetQuery, ErrorOr<MixedClothBucketList>>
{
    private readonly IAuthorizationFacade _authorizationFacade;
    private readonly IClothRepository _clothRepository;
    private readonly IProfileRepository _profileRepository;

    public GetClosetQueryHandler(
        IAuthorizationFacade authorizationFacade,
        IClothRepository clothRepository, 
        IProfileRepository profileRepository)
    {
        _authorizationFacade = authorizationFacade;
        _clothRepository = clothRepository;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<MixedClothBucketList>> Handle(
        GetClosetQuery request, 
        CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);
        
        var profile = await _authorizationFacade.GetAuthProfileByEmailAsync(request.Email, cancellationToken);

        var validationResult = profile
            .AddValidate(email);
        
        if (validationResult.IsError)
        {
            return validationResult.Errors;
        }

        var clothList = await _profileRepository.GetClosetCloth(profile.Value.Id, cancellationToken);
        var bucketList = await _profileRepository.GetBucketCloth(profile.Value.Id, cancellationToken);

        return new MixedClothBucketList(clothList, bucketList);
    }

    private static bool IsMainProfile(ProfileId currentProfile, ErrorOr<Profile> profile)
    {
        return currentProfile == profile.Value.Id;
    }
}