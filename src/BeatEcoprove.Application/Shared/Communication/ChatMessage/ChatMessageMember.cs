using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.ChatMessage;

public record ChatMessageMember(
    ProfileId Id,
    string Username,
    string AvatarPicture
);