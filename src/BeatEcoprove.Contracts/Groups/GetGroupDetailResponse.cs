using BeatEcoprove.Contracts.Profile;

namespace BeatEcoprove.Contracts.Groups;

public record GetGroupDetailResponse
(
    Guid Id,
    string Name,
    string Description,
    int MembersCount,
    int SustainablePoints,
    double Xp,
    bool IsPublic,
    string AvatarPicture,
    ProfileResponse Creator,
    List<ProfileResponse> Members,
    List<ProfileResponse> Admins
);