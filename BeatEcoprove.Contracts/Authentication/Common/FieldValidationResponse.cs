namespace BeatEcoprove.Contracts;

public record class FieldValidationResponse
(
    string FieldName,
    bool IsAvailable
);
