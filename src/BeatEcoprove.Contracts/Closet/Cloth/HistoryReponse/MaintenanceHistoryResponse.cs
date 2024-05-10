
namespace BeatEcoprove.Contracts.Closet.Cloth.HistoryResponse;

public class MaintenanceHistoryResponse : HistoryResponse
{
    public string ProvidedService { get; init; }
    public string ProvidedAction { get; init; }

    public MaintenanceHistoryResponse(
        string providedAction,
        string providedService,
        DateTimeOffset endedAt,
        string type
    ) : base(endedAt, type)
    {
        ProvidedAction = providedAction;
        ProvidedService = providedService;
    }
}