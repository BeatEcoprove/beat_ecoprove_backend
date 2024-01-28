using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Application.FeedBacks.Commands.Common;

public record FeedBackResult
(
    Guid Id,
    Profile Sender,
    string Title,
    string Description
);