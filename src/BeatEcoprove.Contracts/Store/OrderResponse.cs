using BeatEcoprove.Contracts.Closet.Bucket;
using BeatEcoprove.Contracts.Profile;
using BeatEcoprove.Contracts.Services;

using ClothResponse = BeatEcoprove.Contracts.Closet.Cloth.ClothResponse;

namespace BeatEcoprove.Contracts.Store;

public class OrderClothResponse : OrderResponse
{
    public OrderClothResponse(
        Guid id, 
        ProfileClosetResponse owner, 
        List<MaintenanceOrderResponse> services, 
        string orderType,
        ClothResponse cloth) : base(id, owner, services, orderType)
    {
        Cloth = cloth;
    }

    public ClothResponse Cloth { get; init; }
}

public class OrderBucketResponse : OrderResponse
{
    public OrderBucketResponse(
        Guid id, 
        ProfileClosetResponse owner, 
        List<MaintenanceOrderResponse> services, 
        string orderType,
        BucketResponse bucket) : base(id, owner, services, orderType)
    {
        Bucket = bucket;
    }

    public BucketResponse Bucket { get; init; }
}

public class OrderResponse
{
    public OrderResponse(
        Guid id, 
        ProfileClosetResponse owner, 
        List<MaintenanceOrderResponse> services, 
        string orderType)
    {
        Id = id;
        Owner = owner;
        Services = services;
        OrderType = orderType;
    }

    public Guid Id { get; init; }
    public ProfileClosetResponse Owner { get; init; }
    public List<MaintenanceOrderResponse> Services { get; init; }
    public string OrderType { get; init; }
}