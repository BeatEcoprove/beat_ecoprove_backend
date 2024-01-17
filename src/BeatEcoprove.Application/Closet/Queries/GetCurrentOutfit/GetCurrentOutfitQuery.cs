using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Queries.GetCurrentOutfit;

public record GetCurrentOutfitQuery
(
    Guid AuthId,
    Guid ProfileId
) : IQuery<ErrorOr<BucketResult>>, IAuthorization;