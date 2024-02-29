using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Domain.ClosetAggregator.Entities;

using ErrorOr;

namespace BeatEcoprove.Application.Services.Queries.GetAllServices;

internal sealed class GetAllServicesQueryHandler : IQueryHandler<GetAllServicesQuery, ErrorOr<List<MaintenanceService>>>
{
    private readonly IMaintenanceServiceRepository _maintenanceServiceRepository;

    public GetAllServicesQueryHandler(IMaintenanceServiceRepository maintenanceServiceRepository)
    {
        _maintenanceServiceRepository = maintenanceServiceRepository;
    }

    public async Task<ErrorOr<List<MaintenanceService>>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
    {
        return await _maintenanceServiceRepository.GetAllServicesAsync(cancellationToken);
    }
}