using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Token
    {
        public static Error InvalidRefreshToken => Error.Validation(
            "Token.InvalidRefreshToken",
            "O token de atualização é inválido.");
    }
}