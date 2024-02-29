using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Username
    {
        public static Error InvalidUsername => Error.Validation(
            "Username.InvalidUsername",
            "Por favor, insira um nome de utilizador válido.");
    }
}