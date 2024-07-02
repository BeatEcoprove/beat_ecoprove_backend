using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Advertisement
    {
        public static Error CannotPerformThis => Error.Conflict(
            "Advertisement.CannotPerformThis",
            "Não tens acesso a criação de anúncios");
        
        public static Error VoucherQuantityBelow0 => Error.Conflict(
            "Advertisement.VoucherQuantityBelow0",
            "O voucher deve pelo menos conter mais do que uma copia");

        public static Error DateMustBeValid => Error.Conflict(
            "Advertisement.DateMustBeValid",
            "Por favor, definina uma intervalo de tempo válido");
        
        public static Error NotFound => Error.NotFound(
            "Advertisement.NotFound",
            "Nenhum anúncio foi encontrado.");
    }
}