namespace BeatEcoprove.Contracts.Profile.Notifications;

public record InviteNotificationResponse
(
    string title,
    Guid GroupId,
    Guid InvitorId,
    string Code
);
