using BeatEcoprove.Contracts.Groups;
using BeatEcoprove.Domain.GroupAggregator;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class GroupMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Group, GroupResponse>();
    }
}