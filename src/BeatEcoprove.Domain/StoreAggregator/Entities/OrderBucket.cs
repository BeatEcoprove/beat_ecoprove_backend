using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Entities;

public sealed class OrderBucket : Order
{
    private OrderBucket() { }
    
    private OrderBucket(
        StoreId store, 
        ProfileId owner, 
        BucketId bucket,
        List<MaintenanceServiceId> services) : base(store, owner, services)
    {
        Bucket = bucket;
    }

    public static OrderBucket Create(
        StoreId store,
        ProfileId owner,
        BucketId bucket,
        List<MaintenanceServiceId> services)
    {
        return new OrderBucket(store, owner, bucket, services);
    }

    public BucketId Bucket { get; private set; } = null!;
    
    public override OrderType Type => OrderType.Bucket;
}