namespace BeatEcoprove.Contracts.Profile.Notifications;

public record InviteNotificationResponse
(
    string Title,
    Guid GroupId,
    Guid InvitorId,
    string Code,
    string Type
);
