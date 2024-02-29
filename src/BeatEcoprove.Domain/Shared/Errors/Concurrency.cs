using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Concurrency
    {
        public static Error SymbolNotDefined => Error.Validation(
            "Concurrency.SymbolNotDefined",
            "O símbolo não foi definido.");
    }
}