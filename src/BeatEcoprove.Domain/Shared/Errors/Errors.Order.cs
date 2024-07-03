using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Order
    {
        public static Error NotFound => Error.NotFound(
            "Order.NotFound",
            "Não foi encontrado nenhum pedido");        
    }
}