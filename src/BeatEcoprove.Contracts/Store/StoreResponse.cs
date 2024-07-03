using BeatEcoprove.Contracts.ValueObjects;

namespace BeatEcoprove.Contracts.Store;

public record StoreResponse
(
    Guid Id,
    string Name,
    int NumberOfWorkers,
    AddressResponse Address,
    int SustainablePoints,
    double TotalRating,
    string Picture,
    int Level,
    CoordinatesResponse Coordinates
);