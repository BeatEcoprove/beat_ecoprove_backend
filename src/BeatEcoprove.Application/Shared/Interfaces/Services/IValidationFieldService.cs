namespace BeatEcoprove.Application;

public interface IValidationFieldService
{
    Task<bool> IsFieldAvailable(string fieldName, string value);
}
