using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Groups;
using BeatEcoprove.Domain.GroupAggregator;
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
    }
}