using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class User 
    {
        public static Error EmailNotValid => Error.Validation(
            "User.EmailNotValid",
            "Por favor, introduza um e-mail válido");
    }
}