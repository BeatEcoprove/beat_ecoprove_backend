namespace BeatEcoprove.Contracts.Profile.Notifications;

public record InviteNotificationResponse
(
    string Title,
    Guid GroupId,
    string GroupName,
    Guid InvitorId,
    string Code,
    string Type
);