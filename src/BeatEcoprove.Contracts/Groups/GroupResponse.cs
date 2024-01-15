using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.Groups;

public record GroupResponse
(
    Guid Id,
    string Name,
    string AvatarPicture,
    string Description,
    int MembersCount,
    int SustainablePoints,
    double Xp,
    bool IsPublic
    );