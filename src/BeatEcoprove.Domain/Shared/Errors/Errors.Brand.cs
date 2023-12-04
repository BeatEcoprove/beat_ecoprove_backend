using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Brand
    {
        public static Error MustProvideBrandName => Error.Unexpected(
            "Brand.MustProvideBrandName",
            "Por favor, forneça um nome para a marca.");      
        
        public static Error MustProvideBrandAvatar => Error.Unexpected(
            "Brand.MustProvideBrandAvatar",
            "Por favor, forneça um avatar para a marca.");
        
        public static Error ThereIsNoBrandName => Error.Unexpected(
            "Brand.ThereIsNoBrandName",
            "Não existe nenhuma marca com esse nome.");
    }
}
