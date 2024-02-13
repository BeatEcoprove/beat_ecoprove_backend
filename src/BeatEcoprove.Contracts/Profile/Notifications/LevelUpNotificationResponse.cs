namespace BeatEcoprove.Contracts.Profile.Notifications;

public record LevelUpNotificationResponse
(
    string Title,
    int StagedLevel,
    double StagedXp,
    string Type
);