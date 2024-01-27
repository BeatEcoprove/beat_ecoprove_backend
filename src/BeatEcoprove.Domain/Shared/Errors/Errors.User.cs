using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class User
    {
        public static Error ProfileDoesNotBelongToAuth => Error.Unexpected(
            "User.ProfileDoesNotBelongToAuth",
            "Este utilizador não tem acesso ao perfil escolhido.");
        
        public static Error ProfileDoesNotExists => Error.Conflict(
            "User.ProfileDoesNotExists",
            "Não foi encontrado nenhum perfil associado ao utilizador.");

        public static Error EmailAlreadyExists => Error.Conflict(
            "User.EmailAlreadyExists",
            "Este email já se encontra em uso.");

        public static Error UserNameAlreadyExists => Error.Conflict(
            "User.UserNameAlreadyExists",
            "Este nome de utilizador já se encontra em uso.");

        public static Error EmailDoesNotExists => Error.Unexpected(
            "User.EmailDoesNotExists",
            "Este email não corresponde a nenhum utilizador.");

        public static Error BadCredentials => Error.Conflict(
            "User.BadCredentials",
            "O email ou a palavra-chave estão erradas.");
        
        public static Error InvalidUserGender => Error.Conflict(
            "User.InvalidUserGender",
            "O género do utilizador não é aceite.");
    }
}