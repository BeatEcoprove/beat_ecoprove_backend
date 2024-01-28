using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.Shared.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Entities;

public class FeedBack : Entity<FeedBackId>
{
    private FeedBack() { }

    public ProfileId Sender { get; set; } = null!;
    public Title Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public DateTimeOffset CreatedAt { get; private set; }
    
    public static ErrorOr<FeedBack> Create(
        ProfileId sender, 
        Title title, 
        string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            return Errors.Errors.FeedBack.DescriptionNotProvided;
        }
        
        var feedBack = new FeedBack
        {
            Id = FeedBackId.CreateUnique(),
            Sender = sender,
            Title = title,
            Description = description,
            CreatedAt = DateTimeOffset.UtcNow
        };

        return feedBack;
    }
}