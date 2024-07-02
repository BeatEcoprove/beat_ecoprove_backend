namespace BeatEcoprove.Contracts.Store;

public record WorkerResponse
(
    Guid Id,
    string Name,
    string Email,
    string Type
);