using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Events;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
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
    public List<Rating> Ratings => _ratingEntries;

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

    public int NumberWorkers => _workerEntries.Count;

    public double GetTotalRating()
    {
        if (_ratingEntries.Count == 0)
        {
            return 0;
        }
        
        return _ratingEntries.Sum(s => s.Rate) / _ratingEntries.Count;
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
    
    public ErrorOr<Worker> SwitchWorkerPermission(Worker worker, WorkerType type)
    {
        var foundWorker = _workerEntries.FirstOrDefault(w => w.Id == worker.Id);
        
        if (foundWorker is null)
        {
            return Errors.Worker.DoesNotBelongToStore;
        }

        var shouldUpgradeRole = foundWorker.UpgradeRole(type);

        if (shouldUpgradeRole.IsError)
        {
            return shouldUpgradeRole.Errors;
        }
        
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
        AddDomainEvent(new CreateOrderDomainEvent(this.Id, Owner));
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

    public ErrorOr<Rating> AddRating(Profile user, double rate)
    {
        if (!user.Type.Equals(UserType.Consumer))
        {
            return Errors.Store.DontHaveAccessToStore;
        }

        var foundRating = _ratingEntries.FirstOrDefault(r => r.User == user.Id);

        if (foundRating is not null)
        {
            foundRating.SetRate(rate);

            return foundRating;
        }

        var rating = Rating.Create(
            this.Id,
            user.Id,
            rate
        );
            
        if (rating.IsError)
        {
            return rating.Errors;
        }            
            
        _ratingEntries.Add(rating.Value);
        return rating;
    }

    public void Complete(OrderCloth order)
    {
        order.Complete();
        AddDomainEvent(new CompleteOrderDomainEvent(Id, Owner));
    }
}