using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;

using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.GetGroups;

public record GetGroupsQuery
(
    Guid AuthId,
    Guid ProfileId,
    string? Search,
     int Page = 1,
     int PageSize = 10
) : IQuery<ErrorOr<GetGroupList>>, IAuthorization;