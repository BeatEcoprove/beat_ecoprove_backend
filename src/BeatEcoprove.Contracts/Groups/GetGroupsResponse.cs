namespace BeatEcoprove.Contracts.Groups;

public record GetGroupsResponse
(
    List<GroupResponse> PublicGroups,
    List<GroupResponse> PrivateGroups
    );