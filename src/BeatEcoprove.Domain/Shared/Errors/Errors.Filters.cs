using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public static class Filters
    {
        public static Error Category => Error.Validation(
            "Filter.Category",
            "O filtro category está mal definido."); 
        public static Error Size => Error.Validation(
            "Filter.Size",
            "O filtro size está mal definido."); 
        
        public static Error Order => Error.Validation(
            "Filter.Order",
            "O filtro order está mal definido."); 
    }
}