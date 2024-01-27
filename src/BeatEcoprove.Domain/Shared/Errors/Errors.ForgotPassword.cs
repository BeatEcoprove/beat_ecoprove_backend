using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class ForgotPassword
    {
        public static Error ForgotTokenNotValid => Error.Conflict(
           "ForgotPassword.ForgotTokenNotValid",
           "O token fornecido já não se encontra válido.");
    }
}
