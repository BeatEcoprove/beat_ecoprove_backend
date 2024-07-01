namespace BeatEcoprove.Application.Shared.Interfaces.Services.Common;

public record GetAllStoreInput(
    List<Guid>? Services = null,
    List<Guid>? Colors = null,
    List<Guid>? Brands = null,
    string? Search = null,
    string? OrderBy = null,  
    int Page = 1,
    int PageSize = 10
);