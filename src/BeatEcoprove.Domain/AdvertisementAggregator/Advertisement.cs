using BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.AdvertisementAggregator;

public class Advertisement : AggregateRoot<AdvertisementId, Guid>
{
    private const int AddCost = 150;
    
    protected Advertisement() { }
    
    protected Advertisement(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        int sustainablePoints)
    {
        Id = AdvertisementId.CreateUnique();
        Creator = creator;
        Title = title;
        Description = description;
        InitDate = initDate;
        EndDate = endDate;
        SustainablePoints = sustainablePoints;
    }

    public StoreId Store { get; private set; }
    public ProfileId Creator { get; private set; } = null!;
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public DateTimeOffset InitDate { get; private set; } 
    public DateTimeOffset EndDate { get; private set; }
    public string Picture { get; private set; } = null!;
    public int SustainablePoints { get; private set; } = 150;
    public virtual AdvertisementType Type { get; protected init; } = AdvertisementType.Advertisement;
    
    public static Advertisement Create(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate)
    {
        return new Advertisement(
            creator,
            title,
            description, 
            initDate, 
            endDate, 
            AddCost
        );
    }

    public void SetStore(StoreId id) => Store = id;

    public void SetPictureUrl(string url)
    {
        Picture = url;
    }

    public void SetMainProfile(ProfileId profileId)
    {
        Creator = profileId;
    }
}