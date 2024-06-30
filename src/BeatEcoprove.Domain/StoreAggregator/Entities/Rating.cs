using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Domain.StoreAggregator.Entities;

public class Rating
{
    private Rating() { }

    private Rating(StoreId store, ProfileId user, double rate)
    {
        Store = store;
        User = user;
        Rate = rate;
    }
    
    public StoreId Store { get; private set; } = null!;
    public ProfileId User { get; private set; } = null!;
    public double Rate { get; private set; } = 0D;
    public DateTimeOffset PublishAt { get; private set; } = DateTimeOffset.Now;
    public DateTimeOffset? DeletedAt { get; private set; }

    public static ErrorOr<Rating> Create(
        StoreId store,
        ProfileId user,
        double rate)
    {
        if (rate is < 0 or > 5)
        {
            return Errors.Store.RateNotAllowed;
        }
        
        return new Rating(store, user, rate);
    }
}