namespace BeatEcoprove.Contracts.Activities;

public record DailyActivityResponse
(
    Guid ClothId,
    float Xp,
    int DailySequence
);