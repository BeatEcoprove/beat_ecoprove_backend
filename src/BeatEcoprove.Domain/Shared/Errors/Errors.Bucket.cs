using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Bucket
    {
        public static Error EmptyClothIds => Error.Validation(
            "Bucket.EmptyClothIds",
            "Por favor, adiciona pelo menos uma peça ao cesto.");
    }
}