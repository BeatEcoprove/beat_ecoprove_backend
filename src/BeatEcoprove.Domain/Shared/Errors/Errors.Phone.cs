using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Phone
    {
        public static Error EmptyPhone => Error.Validation(
            "Phone.EmptyPhone",
            "O código e a palavra-chave devem ser introduzidos.");

        public static Error InvalidPhone => Error.Validation(
            "Phone.InvalidPhone",
            "Por favor introduza um código de país válido.");

        public static Error MustBeNineLegth => Error.Validation(
            "Phone.InvalidPhone",
            "A telemóvel deve ter nove digítos.");
    }
}