using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts;
using ErrorOr;

namespace BeatEcoprove.Application;

public class ValidationFieldQueryHandler : IQueryHandler<ValidationFieldQuery, ErrorOr<FieldValidationResponse>>
{
    private readonly IValidationFieldService _validationFieldService;

    public ValidationFieldQueryHandler(IValidationFieldService validationFieldService)
    {
        _validationFieldService = validationFieldService;
    }

    public async Task<ErrorOr<FieldValidationResponse>> Handle(ValidationFieldQuery request, CancellationToken cancellationToken)
    {
        var result = await _validationFieldService
            .IsFieldAvailable(request.FieldName, request.Value);

        return new FieldValidationResponse(
            request.FieldName,
            result
        );
    }
}
