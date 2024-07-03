using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Daos;

public class OrderBucketDao : OrderDAO
{
    public OrderBucketDao(
        OrderId id, 
        StoreId storeId, 
        Profile owner, 
        OrderStatus status, 
        DateTimeOffset? acceptedAt, 
        OrderType type,
        List<ClothDao> cloths) : base(id, storeId, owner, status, acceptedAt, type)
    {
        Cloths = cloths;
    }

    public List<ClothDao> Cloths { get; private set; }
}
