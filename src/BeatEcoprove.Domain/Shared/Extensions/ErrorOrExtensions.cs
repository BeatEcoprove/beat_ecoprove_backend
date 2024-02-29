using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Extensions;

public static class ErrorOrExtensions
{
    public static ErrorOr<T> AddValidate<T, TU>(this ErrorOr<T> errorOr, ErrorOr<TU> nextError)
        where T : notnull
        where TU : notnull
    {
        if (nextError.IsError)
        {
            return nextError.Errors;
        }

        return errorOr;
    }
}