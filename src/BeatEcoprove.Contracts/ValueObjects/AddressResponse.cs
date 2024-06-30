namespace BeatEcoprove.Contracts.ValueObjects;

public record AddressResponse
(
    string Street,
    string PostalCode,
    string Locality,
    string Port
);