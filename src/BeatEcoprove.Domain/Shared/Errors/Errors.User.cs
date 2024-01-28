using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class User
    {
        public static Error ProfileDoesNotBelongToAuth => Error.Unexpected(
            "User.ProfileDoesNotBelongToAuth",
            "Este utilizador não tem acesso ao perfil escolhido.");
        
        public static Error ProfileDoesNotExists => Error.Validation(
            "User.ProfileDoesNotExists",
            "Não foi encontrado nenhum perfil associado ao utilizador.");

        public static Error EmailAlreadyExists => Error.Validation(
            "User.EmailAlreadyExists",
            "Este email já se encontra em uso.");

        public static Error UserNameAlreadyExists => Error.Validation(
            "User.UserNameAlreadyExists",
            "Este nome de utilizador já se encontra em uso.");

        public static Error EmailDoesNotExists => Error.Unexpected(
            "User.EmailDoesNotExists",
            "Este email não corresponde a nenhum utilizador.");

        public static Error BadCredentials => Error.Validation(
            "User.BadCredentials",
            "O email ou a palavra-chave estão erradas.");
        
        public static Error InvalidUserGender => Error.Validation(
            "User.InvalidUserGender",
            "O género do utilizador não é aceite.");
    }
}