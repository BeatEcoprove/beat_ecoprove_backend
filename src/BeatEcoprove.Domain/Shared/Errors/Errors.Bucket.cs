using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Bucket
    {
        public static Error InvalidClothToAdd => Error.Conflict(
            "Bucket.InvalidClothToAdd",
            "Roupa não encontrada.");

        public static Error EmptyClothIds => Error.Conflict(
            "Bucket.EmptyClothIds",
            "Por favor, adiciona pelo menos uma peça ao cesto.");

        public static Error ClothAreNotUnique => Error.Conflict(
            "Bucket.ClothAreNotUnique",
            "Por favor, adicione apenas uma vez a peça de roupa.");

        public static Error CanAddClothToBucket => Error.Conflict(
            "Bucket.CanAddClothToBucket",
            "Por favor, essa roupa já está num cesto.");

        public static Error CannotRemoveCloth => Error.Conflict(
            "Bucket.CannotRemoveCloth",
            "Não é possível remover esta peça de roupa do cesto.");

        public static Error BucketNameAlreadyUsed => Error.Conflict(
            "Bucket.BucketNameAlreadyUsed",
            "Por favor, escolha um nome diferente para o cesto.");

        public static Error InvalidBucketName => Error.Validation(
            "Bucket.InvalidBucketName",
            "Por favor, escolha um nome válido para o cesto.");

        public static Error BucketDoesNotExists => Error.Conflict(
            "Bucket.BucketDoesNotExists",
            "Falha ao encontrar o cesto.");

        public static Error CannotAccessBucket => Error.Conflict(
            "Bucket.CannotAccessBucket",
            "Este cesto não lhe pertence.");

        public static Error NameCannotBeEmpty => Error.Validation(
            "Bucket.NameCannotBeEmpty",
            "Por favor preencha um nome para o cesto.");
    }
}