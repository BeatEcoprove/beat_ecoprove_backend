using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator.DAOS;

using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.GetGroupDetail;

public record GetGroupDetailQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid GroupId
) : IQuery<ErrorOr<GroupDao>>, IAuthorization;