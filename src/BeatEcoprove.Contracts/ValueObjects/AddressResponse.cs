namespace BeatEcoprove.Contracts.ValueObjects;

public record AddressResponse
(
    string Street,
    PostalCodeResponse PostalCode,
    string Locality,
    string Port
);