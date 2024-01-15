using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.GetGroups;

public record GetGroupsQuery
(
    Guid AuthId,
    Guid ProfileId,
     int Page = 1,
     int PageSize = 10
) : IQuery<ErrorOr<GetGroupList>>, IAuthorization;