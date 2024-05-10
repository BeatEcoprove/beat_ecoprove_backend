
namespace BeatEcoprove.Contracts.Closet.Cloth.HistoryResponse;

public class DailyHistoryResponse : HistoryResponse
{
    public DailyHistoryResponse(
        string title,
        DateTimeOffset endedAt,
        string type
    ) : base(endedAt, type)
    {
        Title = title;
    }

    public string Title { get; init; }
}