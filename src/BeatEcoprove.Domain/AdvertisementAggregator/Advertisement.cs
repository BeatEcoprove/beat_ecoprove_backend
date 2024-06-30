using BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.AdvertisementAggregator;

public class Advertisement : AggregateRoot<AdvertisementId, Guid>
{
    protected Advertisement() { }
    
    protected Advertisement(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        string picture, 
        int sustainablePoints)
    {
        Creator = creator;
        Title = title;
        Description = description;
        InitDate = initDate;
        EndDate = endDate;
        Picture = picture;
        SustainablePoints = sustainablePoints;
    }

    public ProfileId Creator { get; private set; } = null!;
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public DateTimeOffset InitDate { get; private set; } 
    public DateTimeOffset EndDate { get; private set; }
    public string Picture { get; private set; } = null!;
    public int SustainablePoints { get; private set; } = 0;
    public virtual AdvertisementType Type { get; protected set; } = AdvertisementType.Advertisement;
    
    public static Advertisement Create(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        string picture, 
        int sustainablePoints
    )
    {
        return new Advertisement(
            creator,
            title,
            description, 
            initDate, 
            endDate, 
            picture, 
            sustainablePoints
        );
    }
}