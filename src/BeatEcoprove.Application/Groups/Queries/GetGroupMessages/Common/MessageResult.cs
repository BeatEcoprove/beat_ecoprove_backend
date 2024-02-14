using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;

public record MessageResult
(
    Guid GroupId,
    Profile Sender,
    string Content,
    DateTimeOffset CreatedAt
);