namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IValidationFieldService
{
    Task<bool> IsFieldAvailable(string fieldName, string value);
}