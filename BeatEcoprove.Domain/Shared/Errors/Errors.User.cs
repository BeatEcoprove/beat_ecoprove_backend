using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class User 
    {
        public static Error EmailAlreadyExists => Error.Validation(
            "User.EmailAlreadyExists",
            "Já existe um utilizador com este e-mail.");
        
        public static Error EmailDoesNotExists => Error.NotFound(
            "User.EmailDoesNotExists",
            "Não existe nenhum utilizador com este e-mail.");
        
        public static Error BadCredentials => Error.NotFound(
            "User.BadCredentials",
            "As chaves de acesso fornecidas não são válidas.");
    }
}