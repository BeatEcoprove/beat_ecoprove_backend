using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

using NetTopologySuite.Geometries;

namespace BeatEcoprove.Domain.StoreAggregator;

public class ServiceProvider<TId, TIdType> : AggregateRoot<TId, TIdType>
    where TId : AggregateRootId<TIdType>
{
    protected ServiceProvider() { }

    protected ServiceProvider(
        ProfileId owner,
        Point localization,
        int sustainablePoints
    )
    {
        Owner = owner;
        Localization = localization;
        SustainablePoints = sustainablePoints;
    }
    
    public ProfileId Owner { get; private set; } = null!;
    public Point Localization { get; private set; } = null!;
    public int SustainablePoints { get; set; }
}