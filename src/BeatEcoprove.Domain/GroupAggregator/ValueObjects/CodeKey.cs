using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.ValueObjects;

public record CodeKey(ProfileId UserId, GroupId GroupId, string Code)
    : Key(UserId.Value.ToString(), GroupId.Value.ToString(), Code);