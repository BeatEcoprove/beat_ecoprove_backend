using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts.Authentication.Common;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Queries.ValidationField;

public record class ValidationFieldQuery
(
    string FieldName,
    string Value
) : IQuery<ErrorOr<FieldValidationResponse>>;
