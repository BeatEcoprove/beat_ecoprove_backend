using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Store;

public record CreateStoreRequest
(
    string Name,
    string Country,
    string Locality,
    string Street,
    string PostalCode,
    int Port,
    double Lat,
    double Lon,
    IFormFile Picture
);