using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Entities;

public abstract class Order : Entity<OrderId>
{
    private readonly List<ServiceEntry> _serviceEntries = new();

    protected Order() { }

    protected Order(
        StoreId store,
        ProfileId owner,
        List<MaintenanceServiceId> services)
    {
        Id = OrderId.CreateUnique();
        Store = store;
        Owner = owner;
        
        AddServices(services);
    }

    public StoreId Store { get; private set; } = null!;
    public ProfileId Owner { get; private set; } = null!;
    public WorkerId AssignedWorker { get; private set; } = null;
    public OrderStatus Status { get; private set; } = OrderStatus.Arrived;
    public DateTimeOffset? AcceptedAt { get; set; } = null;
    public IReadOnlyList<ServiceEntry> Services => _serviceEntries.AsReadOnly();
    
    public virtual OrderType Type { get; private set; }

    public void Assign(Worker worker)
    {
        AssignedWorker = worker.Id;
        Status = OrderStatus.Assigned;
        AcceptedAt = DateTimeOffset.Now;
    }

    public void Complete()
    {
        Status = OrderStatus.Completed;
    }
    
    public void Reject()
    {
        Status = OrderStatus.Rejected;
    }
    
    public ServiceEntry AddService(MaintenanceServiceId service)
    {
        var entry = ServiceEntry.Create(
            this.Id,
            service
        );

        _serviceEntries.Add(entry);
        return entry;
    }

    public List<ServiceEntry> AddServices(List<MaintenanceServiceId> services)
    {
        var addedServices = services
            .Select(service => ServiceEntry.Create(this.Id, service))
            .ToList();
        
        _serviceEntries.AddRange(addedServices);
        return addedServices;
    }
}