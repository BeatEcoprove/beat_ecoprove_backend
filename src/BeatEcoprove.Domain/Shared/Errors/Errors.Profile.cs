using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Profile
    {
        public static Error CannotFindCloth => Error.Conflict(
            "Profile.CannotFindCloth",
            "Não foi possível encontrar a peça de roupa.");
        
        public static Error CannotFindBucket => Error.Conflict(
            "Profile.CannotFindCloth",
            "Não foi possível encontrar o cesto.");

        public static Error CannotConvertNegativeEcoCoins => Error.Conflict(
            "Profile.CannotConvertNegativeEcoCoins",
            "Não é possível converter um número negativo de EcoCoins.");
        
        public static Error NotEnoughEcoCoins => Error.Conflict(
            "Profile.NotEnoughEcoCoins",
            "Não tens EcoCoins suficientes.");

    }
}