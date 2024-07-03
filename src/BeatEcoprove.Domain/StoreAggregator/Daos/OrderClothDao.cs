using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Daos;

public class OrderClothDao : OrderDAO
{
    public OrderClothDao(
        OrderId id, 
        StoreId storeId, 
        Profile owner, 
        OrderStatus status, 
        DateTimeOffset? acceptedAt, 
        OrderType type,
        ClothDao cloth) : base(id, storeId, owner, status, acceptedAt, type)
    {
        Cloth = cloth;
    }

    public ClothDao Cloth { get; private set; }
}