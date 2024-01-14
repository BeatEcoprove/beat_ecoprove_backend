using BeatEcoprove.Domain.GroupAggregator;

namespace BeatEcoprove.Application.Shared.Helpers;

public record GetGroupList
(
    List<Group> Public,
    List<Group> MyPrivateGroups
);