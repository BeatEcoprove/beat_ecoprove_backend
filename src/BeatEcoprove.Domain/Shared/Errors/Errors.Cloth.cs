using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Cloth
    {
        public static Error InvalidClothName => Error.Validation(
            "Cloth.InvalidClothName",
            "Por favor, intreduz um nome válido.");
        
        public static Error InvalidClothType => Error.Validation(
            "Cloth.InvalidClothType",
            "Por favor, intreduz um tipo de peça válido.");
        
        public static Error InvalidClothSize => Error.Validation(
            "Cloth.InvalidClothSize",
            "Por favor, intreduz um tamanho válido (xs, s, m, l, xl, xxl).");
    }
}