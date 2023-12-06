using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Profile
    {
        public static Error CannotFindCloth => Error.Validation(
            "Profile.CannotFindCloth",
            "Não foi possível encontrar a peça de roupa.");
        
        public static Error CannotFindBucket => Error.Validation(
            "Profile.CannotFindCloth",
            "Não foi possível encontrar o cesto."); 
    }
}