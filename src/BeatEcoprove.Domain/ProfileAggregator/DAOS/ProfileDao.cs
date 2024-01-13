using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Domain.ProfileAggregator.DAOS;

public record ProfileDao
(
    Profile Profile,
    bool IsNested
);