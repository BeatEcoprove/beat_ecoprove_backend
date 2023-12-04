using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Queries.GetBucket;

public record GetBucketQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid BucketId
) : IQuery<ErrorOr<BucketResult>>, IAuthorization;