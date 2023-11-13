using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.ClothAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries.GetCloset;

public record GetClosetQuery
(
    Guid ProfileId,
    string Email
) : IQuery<ErrorOr<MixedClothBucketList>>;