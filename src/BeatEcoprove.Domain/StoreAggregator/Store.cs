using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

using NetTopologySuite.Geometries;

namespace BeatEcoprove.Domain.StoreAggregator;

public class Store : ServiceProvider<StoreId, Guid>
{
    private readonly List<Order> _orderEntries = new();
    private readonly List<Worker> _workerEntries = new();
    private readonly List<Rating> _ratingEntries = new();
    
    private Store() { }
    
    private Store(
        StoreId id,
        ProfileId owner, 
        string name, 
        Address address, 
        Point localization
    ) : base(owner, localization, 0)
    {
        Id = id;
        Name = name;
        Address = address;
        Level = 0;
    }

    public string Name { get; private set; } = null!;
    public Address Address { get; private set; } = null!;
    public double TotalRate => Ratings.Sum(rating => rating.Rate);
    public string Picture { get; private set; } = null!;
    public int Level { get; private set; }
    public List<Worker> Workers => _workerEntries;
    public List<Order> Orders => _orderEntries;
    public IReadOnlyList<Rating> Ratings => _ratingEntries.AsReadOnly();

    public static Store Create(
        ProfileId owner,
        string name, 
        Address address, 
        Point coordinates)
    {
        return new Store(
            StoreId.CreateUnique(),
            owner,
            name,
            address,
            coordinates
        );
    }

    public void SetPictureUrl(string url)
    {
        Picture = url;
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

    public ErrorOr<Rating> AddRating(ProfileId user, double rate) 
    {
        var rating = Rating.Create(
            this.Id,
            user,
            rate
        );

        if (rating.IsError)
        {
            return rating.Errors;
        }
        
        _ratingEntries.Add(rating.Value);
        return rating;
    }
}