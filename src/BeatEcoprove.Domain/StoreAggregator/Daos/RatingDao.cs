using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Daos;

public class RatingDao
{
    public RatingDao(StoreId id, double rating, Profile profile)
    {
        Id = id;
        Rating = rating;
        Profile = profile;
    }

    public StoreId Id { get; init; } = null!;
    public double Rating { get; init; }
    public Profile Profile { get; init; } = null!;
}