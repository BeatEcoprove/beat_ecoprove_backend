using BeatEcoprove.Domain.ClosetAggregator.Entities;

namespace BeatEcoprove.Application.Cloths.Queries.Common.HistoryResult;

public class MaintenaceHistoryResult : HistoryResult
{
    public MaintenaceHistoryResult(
        string providedService,
        string providedAction,
        DateTimeOffset endedAt
    ) : base(endedAt)
    {
        ProvidedService = providedService;
        ProvidedAction = providedAction;
    }

    public string ProvidedService { get; init; }
    public string ProvidedAction { get; init; }

    public override string Type => nameof(MaintenanceActivity);
}