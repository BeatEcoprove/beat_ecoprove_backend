
namespace BeatEcoprove.Contracts.Closet.Cloth.HistoryResponse;

public class HistoryResponse
{
    public HistoryResponse(
        DateTimeOffset endedAt,
        string type
    )
    {
        EndedAt = endedAt;
        Type = type;
    }

    public DateTimeOffset EndedAt { get; init; }
    public string Type { get; init; }
}