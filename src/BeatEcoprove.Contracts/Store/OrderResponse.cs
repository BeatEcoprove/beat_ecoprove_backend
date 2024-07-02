using BeatEcoprove.Contracts.Closet.Bucket;
using BeatEcoprove.Contracts.Closet.Cloth;
using BeatEcoprove.Contracts.Services;

namespace BeatEcoprove.Contracts.Store;

public class OrderClothResponse : OrderResponse
{
    public OrderClothResponse(
        Guid id, 
        Guid ownerId, 
        List<MaintenanceOrderResponse> services, 
        string orderType,
        ClothResponse cloth) : base(id, ownerId, services, orderType)
    {
        Cloth = cloth;
    }

    public ClothResponse Cloth { get; init; }
}

public class OrderBucketResponse : OrderResponse
{
    public OrderBucketResponse(
        Guid id, 
        Guid ownerId, 
        List<MaintenanceOrderResponse> services, 
        string orderType,
        BucketResponse bucket) : base(id, ownerId, services, orderType)
    {
        Bucket = bucket;
    }

    public BucketResponse Bucket { get; init; }
}

public class OrderResponse
{
    public OrderResponse(
        Guid id, 
        Guid ownerId, 
        List<MaintenanceOrderResponse> services, 
        string orderType)
    {
        Id = id;
        OwnerId = ownerId;
        Services = services;
        OrderType = orderType;
    }

    public Guid Id { get; init; }
    public Guid OwnerId { get; init; }
    public List<MaintenanceOrderResponse> Services { get; init; }
    public string OrderType { get; init; }
}