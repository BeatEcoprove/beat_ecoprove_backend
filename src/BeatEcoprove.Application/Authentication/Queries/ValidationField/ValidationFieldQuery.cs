using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts;
using ErrorOr;

namespace BeatEcoprove.Application;

public record class ValidationFieldQuery
(
    string FieldName,
    string Value
) : IQuery<ErrorOr<FieldValidationResponse>>;
