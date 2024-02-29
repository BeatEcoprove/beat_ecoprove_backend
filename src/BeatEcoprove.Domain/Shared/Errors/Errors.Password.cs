using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Password
    {
        public static Error EmptyPassword => Error.Validation(
            "Password.EmptyPassword",
            "Por favor, introduza uma password.");

        public static Error MustBeBetween6And16 => Error.Validation(
            "Password.MustBeBetween6And16",
            "A palavra-chave deve ter entre 6 a 16 caracteres");

        public static Error MustContainAtLeastOnNumber => Error.Validation(
            "Password.MustContainAtLeastOnNumber",
            "A palavra-chave deve conter pelo menos 1 número");

        public static Error MustContainAtLeastOnCaptialLetter => Error.Validation(
            "Password.MustContainAtLeastOnCaptialLetter",
            "A palavra-chave deve conter pelo menos uma letra maiúscula");

        public static Error MustContainAtLeastLetter => Error.Validation(
            "Password.MustContainAtLeastLetter",
            "A palavra-chave deve conter pelo menos uma letra minúscula");
    }
}