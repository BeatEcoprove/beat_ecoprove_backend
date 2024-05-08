using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.Group;

public record InviteGroupContent
(
    string Code,
    GroupId Group,
    string GroupName,
    ProfileId From
)
{
    public string Message => "Foi Convidado";
};