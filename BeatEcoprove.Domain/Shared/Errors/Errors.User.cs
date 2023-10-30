using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class User
    {
        public static Error EmailAlreadyExists => Error.Validation(
            "User.EmailAlreadyExists",
            "Este email já se encontra em uso.");

        public static Error UserNameAlreadyExists => Error.Validation(
            "User.UserNameAlreadyExists",
            "Este nome de utilizador já se encontra em uso.");

        public static Error EmailDoesNotExists => Error.NotFound(
            "User.EmailDoesNotExists",
            "Este email não corresponde a nenhum utilizador.");

        public static Error BadCredentials => Error.Validation(
            "User.BadCredentials",
            "O email ou a palavra-chave estão erradas.");
    }
}