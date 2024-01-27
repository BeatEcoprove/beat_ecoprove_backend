using BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.GroupAggregator.Entities;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Queries.GetGroupMessages;

public record GetGroupMessagesQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid GroupId,
    int Page,
    int PageSize
) : IQuery<ErrorOr<List<MessageResult>>>, IAuthorization;