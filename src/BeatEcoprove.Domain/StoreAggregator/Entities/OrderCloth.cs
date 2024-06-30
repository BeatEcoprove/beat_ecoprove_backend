using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Entities;

public sealed class OrderCloth : Order
{
    private OrderCloth() { }
    
    private OrderCloth(
        StoreId store, 
        ProfileId owner, 
        ClothId cloth,
        List<MaintenanceServiceId> services) : base(store, owner, services)
    {
        Cloth = cloth;
    }

    public static OrderCloth Create(
        StoreId store,
        ProfileId owner,
        ClothId cloth,
        List<MaintenanceServiceId> services)
    {
        return new OrderCloth(store, owner, cloth, services);
    }

    public ClothId Cloth { get; private set; } = null!;
    
    public override OrderType Type => OrderType.Cloth;
}