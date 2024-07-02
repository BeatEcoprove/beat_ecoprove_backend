namespace BeatEcoprove.Contracts.Advertisements;

public class AdvertisementResponse
{
    public AdvertisementResponse(
        Guid id, 
        string title, 
        string description, 
        string picture,
        DateTimeOffset beginAt, 
        DateTimeOffset endAt, 
        string type)
    {
        Id = id;
        Title = title;
        Description = description;
        Picture = picture;
        BeginAt = beginAt;
        EndAt = endAt;
        Type = type;
    }

    public Guid Id { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }
    public string Picture { get; init; }
    public DateTimeOffset BeginAt { get; init; }
    public DateTimeOffset EndAt { get; init; }
    public string Type { get; init; }
}