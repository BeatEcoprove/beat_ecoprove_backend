namespace BeatEcoprove.Contracts.Profile;

public record ProfileResponse
(
    Guid Id,
    string Username,
    int Level,
    float LevelPercentage,
    int SustainabilityPoints,
    string AvatarUrl
);