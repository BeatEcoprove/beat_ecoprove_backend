using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.ChatMessage;

public class TextMessage
{
    public string Message { get; init; }
    public GroupId Group { get; init; }
    public ChatMessageMember Member { get; init; }

    public TextMessage(string message, GroupId group, ChatMessageMember member)
    {
        Message = message;
        Group = group;
        Member = member;
    }
}