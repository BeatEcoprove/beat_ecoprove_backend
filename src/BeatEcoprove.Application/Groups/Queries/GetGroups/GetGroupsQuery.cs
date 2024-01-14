using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.GetGroups;

public record GetGroupsQuery
(
    Guid AuthId,
    Guid ProfileId
) : IQuery<ErrorOr<GetGroupList>>, IAuthorization;