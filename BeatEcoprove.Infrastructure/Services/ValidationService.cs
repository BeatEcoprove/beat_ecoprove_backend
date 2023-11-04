using BeatEcoprove.Application;

namespace BeatEcoprove.Infrastructure.Services;

public class ValidationFieldService : IValidationFieldService
{
    public Task<bool> IsFieldAvailable(string fieldName, string value)
    {
        throw new NotImplementedException();
    }
}
