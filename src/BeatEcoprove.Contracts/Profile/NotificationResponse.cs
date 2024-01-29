namespace BeatEcoprove.Contracts.Profile;

public record NotificationResponse
(
    Guid UserId,
    string Title,
    Guid GroupId,
    Guid InvitorId,
    string Code
);