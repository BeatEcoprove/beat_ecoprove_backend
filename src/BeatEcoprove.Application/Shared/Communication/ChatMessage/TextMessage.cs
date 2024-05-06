using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.ChatMessage;

public class TextMessage
{
    public string Id { get; set; }
    public string Message { get; init; }
    public GroupId Group { get; init; }
    public ChatMessageMember Member { get; init; }

    public TextMessage(
        string id,
        string message,
        GroupId group,
        ChatMessageMember member)
    {
        Id = id;
        Message = message;
        Group = group;
        Member = member;
    }
}