using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Queries.GetCloset;

public record GetClosetQuery
(
    Guid AuthId,
    Guid ProfileId,
    string? Categories,
    string? Size,
    string? Color,
    string? Brand,
    string? OrderBy,
    string? SortBy,
    int Page = 1,
    int PageSize = 10
) : IQuery<ErrorOr<MixedClothBucketList>>, IAuthorization;