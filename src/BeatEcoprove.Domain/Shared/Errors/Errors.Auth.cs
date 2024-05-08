using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Auth
    {
        public static Error InvalidAuth => Error.Conflict(
            "Auth.InvalidAuth",
            "Senha de accesso inválida.");
    }
}