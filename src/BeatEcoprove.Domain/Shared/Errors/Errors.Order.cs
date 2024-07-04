using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Order
    {
        public static Error NotFound => Error.NotFound(
            "Order.NotFound",
            "Não foi encontrado nenhum pedido");        
        
        public static Error IsAlreadyCompleted => Error.NotFound(
            "Order.IsAlreadyCompleted",
            "Este pedido já se encontra terminado!");     
    }
}