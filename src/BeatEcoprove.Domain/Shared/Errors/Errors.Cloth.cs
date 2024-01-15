using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Cloth
    {
        public static Error InvalidClothName => Error.Validation(
            "Cloth.InvalidClothName",
            "Por favor, introduz um nome válido.");

        public static Error ClothNotFound => Error.Validation(
            "Cloth.ClothNotFound",
            "A peça que tentou aceder não existe.");
        
        public static Error MaintenanceActivityNotFound => Error.Conflict(
            "Cloth.MaintenanceActivityNotFound",
            "Esta peça não possui nenhum registo de manutenções anteriores.");
        
        public static Error InvalidClothType => Error.Validation(
            "Cloth.InvalidClothType",
            "Por favor, introduz um tipo de peça válido.");
        
        public static Error InvalidClothSize => Error.Validation(
            "Cloth.InvalidClothSize",
            "Por favor, introduz um tamanho válido (xs, s, m, l, xl, xxl).");

        public static Error CannotUseCloth => Error.Validation(
            "Cloth.CannotUseCloth",
            "Esta peça já está em uso.");
        
        public static Error IsBeingMaintain => Error.Conflict(
            "Cloth.IsBeingMaintain",
            "Esta peça já se encontra em manutenção.");
        
        public static Error CannotDisposeCloth => Error.Validation(
            "Cloth.CannotDisposeCloth",
            "Não é possível demarcar esta peça, porque não está em uso.");
        
        public static Error CannotFinishMaintenanceActivity => Error.Conflict(
            "Cloth.CannotFinishMaintenanceActivity",
            "Não é possível terminar a terefa de manutenção.");
        
        public static Error CannotAccessBucket => Error.Validation(
            "Cloth.CannotAccessBucket",
            "Esta peça de roupa não lhe pertence.");
    }
}