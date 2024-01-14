using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Groups;
using BeatEcoprove.Contracts.Profile;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.DAOS;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class GroupMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Group, GroupResponse>();
        
        config.NewConfig<GetGroupList, GetGroupsResponse>()
            .MapWith(dest => new GetGroupsResponse(
                dest.Public.Adapt<List<GroupResponse>>(),
                dest.MyPrivateGroups.Adapt<List<GroupResponse>>()));

        config.NewConfig<GroupDao, GetGroupDetailResponse>()
            .MapWith(src => new GetGroupDetailResponse(
                src.Id,
                src.Name,
                src.Description,
                src.MembersCount,
                src.SustainablePoints,
                src.Xp,
                src.IsPublic,
                src.AvatarPicture,
                src.Creator.Adapt<ProfileResponse>(),
                src.Members.Adapt<List<ProfileResponse>>(),
                src.Admins.Adapt<List<ProfileResponse>>())
            );
    }
}