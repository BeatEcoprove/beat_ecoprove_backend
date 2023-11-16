using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Color
    {
        public static Error MustProvideColor => Error.Conflict(
            "Color.MustProvideColor",
            "Cor mal definida.");
        
        public static Error BadHexValue => Error.Conflict(
            "Color.BadHexValue",
            "Cor não permitida.");
    }
}