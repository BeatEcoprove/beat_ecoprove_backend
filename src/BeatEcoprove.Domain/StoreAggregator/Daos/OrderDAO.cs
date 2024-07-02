using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Daos;

public class OrderDAO
{
    public OrderDAO(
        OrderId id,
        StoreId storeId, 
        ProfileId owner, 
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
    public ProfileId Owner { get; private set; }
    public OrderStatus Status { get; private set; }
    public DateTimeOffset? AcceptedAt { get; set; } = null;
    public List<MaintenanceOrderDao> MaintenanceServices { get; set; } = new();
    public virtual OrderType Type { get; private set; }
}