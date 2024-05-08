using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Brand
    {
        public static Error MustProvideBrandName => Error.Conflict(
            "Brand.MustProvideBrandName",
            "Por favor, forneça um nome para a marca.");

        public static Error MustProvideBrandAvatar => Error.Conflict(
            "Brand.MustProvideBrandAvatar",
            "Por favor, forneça um avatar para a marca.");

        public static Error ThereIsNoBrandName => Error.Conflict(
            "Brand.ThereIsNoBrandName",
            "Não existe nenhuma marca com esse nome.");
    }
}