using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Daos;

public class OrderDAO
{
    public OrderDAO(
        OrderId id,
        StoreId storeId, 
        Profile owner, 
        OrderStatus status, 
        DateTimeOffset? acceptedAt, 
        OrderType type)
    {
        Id = id;
        StoreId = storeId;
        Owner = owner;
        Status = status;
        AcceptedAt = acceptedAt;
        Type = type;
    }

    public OrderId Id { get; private set; }
    public StoreId StoreId { get; private set; }
    public Profile Owner{ get; private set; }
    public OrderStatus Status { get; private set; }
    public DateTimeOffset? AcceptedAt { get; set; } = null;
    public List<MaintenanceOrderDao> MaintenanceServices { get; set; } = new();
    public virtual OrderType Type { get; private set; }
}