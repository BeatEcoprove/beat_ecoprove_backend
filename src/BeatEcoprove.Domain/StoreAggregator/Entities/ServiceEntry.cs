using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Entities;

public class ServiceEntry
{
    private ServiceEntry() { }
    
    private ServiceEntry(OrderId order, MaintenanceServiceId service)
    {
        Service = service;
        Order = order;
    }

    public MaintenanceServiceId Service { get; private set; } = null!;
    public OrderId Order { get; private set; } = null!;
    public DateTimeOffset? DeletedAt { get; private set; } = null;

    public static ServiceEntry Create(OrderId order, MaintenanceServiceId service)
    {
        return new ServiceEntry(order, service);
    }
}