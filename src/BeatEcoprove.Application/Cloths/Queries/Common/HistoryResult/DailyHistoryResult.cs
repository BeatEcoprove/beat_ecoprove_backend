
using BeatEcoprove.Domain.ClosetAggregator.Entities;

namespace BeatEcoprove.Application.Cloths.Queries.Common.HistoryResult;

public class DailyHistoryResult : HistoryResult
{
    public DailyHistoryResult(
        string title,
        DateTimeOffset endedAt
    ) : base(endedAt)
    {
        Title = title;
    }

    public string Title { get; set; }

    public override string Type => nameof(DailyUseActivity);
}