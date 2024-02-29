using BeatEcoprove.Contracts.Services;
using BeatEcoprove.Domain.ClosetAggregator.Entities;

using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ActivityMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<MaintenanceService, MaintenanceServiceResponse>()
            .MapWith(src => new MaintenanceServiceResponse(
                src.Id,
                src.Title,
                src.Badge,
                src.Description,
                src.MaintenanceActions.Adapt<List<MaintenanceActionResponse>>()
            ));
    }
}