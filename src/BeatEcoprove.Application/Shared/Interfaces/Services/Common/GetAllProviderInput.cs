namespace BeatEcoprove.Application.Shared.Interfaces.Services.Common;

public record GetAllProviderInput
(
    string? Search = null,
    int Page = 1,
    int PageSize = 10
);