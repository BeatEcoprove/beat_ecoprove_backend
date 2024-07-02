namespace BeatEcoprove.Contracts.Store;

public record CreateWorkerRequest
(
    string Name,
    string Email,
    string Permission
);