using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class PostalCode 
    {
        public static Error EmptyPostalCode => Error.Validation(
            "PostalCode.EmptyPostalCode",
            "Por favor, introduza um código postal."); 
        
        public static Error InvalidPostalCode => Error.Validation(
            "PostalCode.InvalidPostalCode",
            "Por favor, introduza um código postal válido");
    }
}