using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using ErrorOr;

namespace BeatEcoprove.Application.Services.Queries.GetAllServices;

public record GetAllServicesQuery
() : IQuery<ErrorOr<List<MaintenanceService>>>;