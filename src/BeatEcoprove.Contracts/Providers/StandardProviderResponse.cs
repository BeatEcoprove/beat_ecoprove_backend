namespace BeatEcoprove.Contracts.Providers;

public record StandardProviderResponse
(
    Guid Id,
    string Picture,
    string Title,
    string Type
);