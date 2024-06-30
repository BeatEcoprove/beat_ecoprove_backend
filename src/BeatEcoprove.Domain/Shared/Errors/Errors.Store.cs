using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Store
    {
        public static Error RateNotAllowed => Error.Conflict(
            "Store.RateNotAllowed",
            "Valor não aceite para o rating da loja");
    }
}