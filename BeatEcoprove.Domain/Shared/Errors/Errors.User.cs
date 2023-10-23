using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class User 
    {
        public static Error EmailAlreadyExists => Error.Validation(
            "User.EmailAlreadyExists",
            "Já existe um utilizador com este e-mail.");
    }
}