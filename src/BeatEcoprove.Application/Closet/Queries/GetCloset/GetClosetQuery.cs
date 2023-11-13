using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Queries.GetCloset;

public record GetClosetQuery
(
    Guid ProfileId,
    string Email
) : IQuery<ErrorOr<MixedClothBucketList>>;