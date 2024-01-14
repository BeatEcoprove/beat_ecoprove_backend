using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Domain.GroupAggregator.DAOS;

public record GroupDao
(
    GroupId Id,
    string Name,
    string Description,
    int MembersCount,
    int SustainablePoints,
    double Xp,
    bool IsPublic,
    string AvatarPicture,
    Profile Creator,
    List<Profile> Members
);