namespace BeatEcoprove.Contracts.Authentication.Common;

public record class FieldValidationResponse
(
    string FieldName,
    bool IsAvailable
);