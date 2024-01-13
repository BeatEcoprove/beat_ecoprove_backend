namespace BeatEcoprove.Contracts.Profile;

public record ProfileResponse
(
    string Username,
    int Level,
    float LevelPercentage,
    int SustainabilityPoints,
    string AvatarUrl
);