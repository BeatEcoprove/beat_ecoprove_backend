using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Concurrency
    {
        public static Error SymbolNotDefined => Error.Conflict(
            "Concurrency.SymbolNotDefined",
            "O símbolo não foi definido.");      
    }
}