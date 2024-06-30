using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using NetTopologySuite.Geometries;

namespace BeatEcoprove.Domain.StoreAggregator;

public class Store : AggregateRoot<StoreId, Guid>
{
    private readonly List<Order> _orderEntries = new();
    private readonly List<Worker> _workerEntries = new();
    
    private Store() { }
    
    private Store(
        StoreId id,
        ProfileId owner, 
        string name, 
        Address address, 
        Point localization, 
        string picture
    )
    {
        Id = id;
        Owner = owner;
        Name = name;
        Address = address;
        Localization = localization;
        Picture = picture;
        SustainablePoints = 0;
        Rating = 0D;
        Level = 0;
    }

    public ProfileId Owner { get; private set; } = null!;
    public string Name { get; private set; } = null!;
    public Point Localization { get; private set; } = null!;
    public Address Address { get; private set; } = null!;
    public int SustainablePoints { get; private set; }
    public double Rating { get; private set; }
    public string Picture { get; private set; } = null!;
    public int Level { get; private set; }
    public IReadOnlyList<Worker> Workers => _workerEntries.AsReadOnly();
    public IReadOnlyList<Order> Orders => _orderEntries.AsReadOnly();

    public static Store Create(
        ProfileId owner,
        string name, 
        Address address, 
        Point coordinates, 
        string picture
    )
    {
        return new Store(
            StoreId.CreateUnique(),
            owner,
            name,
            address,
            coordinates,
            picture
        );
    }

    public Worker AddWorker(Profile profile, WorkerType type)
    {
        var worker = Worker.Create(
            Id,
            profile.Id,
            type
        );

        _workerEntries.Add(worker);
        return worker;
    }

    public OrderCloth RegisterOrderCloth(ProfileId owner, ClothId cloth, List<MaintenanceServiceId> services)
    {
        var orderCloth = OrderCloth.Create(
            this.Id,
            owner,
            cloth,
            services
        );

        _orderEntries.Add(orderCloth);
        return orderCloth;
    }

    public OrderBucket RegisterOrderBucket(ProfileId owner, BucketId bucket, List<MaintenanceServiceId> services)
    {
        var orderBucket = OrderBucket.Create(
            this.Id,
            owner,
            bucket, 
            services
        );

        _orderEntries.Add(orderBucket);
        return orderBucket;
    }
}