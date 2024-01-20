namespace BeatEcoprove.Contracts.Profile;

public record ProfileClosetResponse
(
    Guid Id,
    string Username,
    string AvatarUrl
);