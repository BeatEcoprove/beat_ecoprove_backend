namespace BeatEcoprove.Application.Cloths.Queries.Common.HistoryResult;

public abstract class HistoryResult
{
    public HistoryResult(DateTimeOffset endedAt)
    {
        EndedAt = endedAt;
    }

    public DateTimeOffset EndedAt { get; init; }
    public abstract string Type { get; }
}