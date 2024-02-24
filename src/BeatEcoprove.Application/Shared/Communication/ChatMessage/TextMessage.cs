using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.ChatMessage;

public record TextMessage
(
    string Message,
    GroupId Group,
    ChatMessageMember Member
);