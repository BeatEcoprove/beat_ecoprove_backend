using BeatEcoprove.Contracts.Services;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ActivityMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<MaintenanceService, MaintenanceServiceResponse>()
            .Map(src => src.IsBeingUsed, dest => false);
    }
}