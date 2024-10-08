using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public static partial class Errors
{
    public class Auth
    {
        private const string ErrorRemovingAuthKey = "Error has occurred while deleting account.";
        
        public static Error FailedRemovingSubProfiles => Error.Conflict(
            "Auth.FailedRemovingSubProfiles",
            ErrorRemovingAuthKey);
        
        public static Error FailedRemovingAuthKey => Error.Conflict(
            "Auth.FailedRemovingAuthKey",
            ErrorRemovingAuthKey);
        
        public static Error InvalidAuth => Error.Conflict(
            "Auth.InvalidAuth",
            "Senha de accesso inválida.");
    }
}