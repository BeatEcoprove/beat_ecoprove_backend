using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Extensions;
using ErrorOr;
using Mapster;

namespace BeatEcoprove.Application.Closet.Queries.GetCloset;

internal sealed class GetClosetQueryHandler : IQueryHandler<GetClosetQuery, ErrorOr<MixedClothBucketList>>
{
    private readonly IProfileManager _profileManager;
    private readonly IProfileRepository _profileRepository;

    public GetClosetQueryHandler(
        IProfileManager profileManager, 
        IProfileRepository profileRepository)
    {
        _profileManager = profileManager;
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<MixedClothBucketList>> Handle(
        GetClosetQuery request, 
        CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var clothList = await _profileRepository.GetClosetCloth(profile.Value.Id, cancellationToken);
        var bucketList = await _profileRepository.GetBucketCloth(profile.Value.Id, cancellationToken);

        return new MixedClothBucketList(
            clothList.Adapt<List<ClothResult>>(), 
            bucketList);
    }
}