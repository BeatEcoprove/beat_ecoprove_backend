using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public static class Filters
    {
        public static Error Category => Error.Conflict(
            "Filter.Category",
            "O filtro category está mal definido."); 
        public static Error Size => Error.Conflict(
            "Filter.Size",
            "O filtro size está mal definido."); 
        
        public static Error Order => Error.Conflict(
            "Filter.Order",
            "O filtro order está mal definido."); 
    }
}