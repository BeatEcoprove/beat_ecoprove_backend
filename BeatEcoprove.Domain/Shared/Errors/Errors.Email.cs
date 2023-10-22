using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Email 
    {
        public static Error EmptyEmail => Error.Validation(
            "Email.EmptyEmail",
            "Por favor, introduza um email."); 
        
        public static Error InvalidEmail => Error.Validation(
            "Email.InvalidEmail",
            "Por favor, introduza um e-mail válido");
    }
}