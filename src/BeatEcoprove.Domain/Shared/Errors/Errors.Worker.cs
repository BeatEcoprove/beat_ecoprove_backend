using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Worker
    {
        public static Error NotAllowedName => Error.Conflict(
            "Worker.NotAllowedName",
            "Por favor introduz um nome valid");
        public static Error CannotChangeToSamePermission => Error.Conflict(
            "Worker.CannotChangeToSamePermission",
            "Não possível alterar para a mesma permissão já atribuida");        
        public static Error NotFound => Error.NotFound(
            "Worker.NotFound",
            "Não existe nenhum trabalhador com esse id");        
        public static Error InvalidPermission => Error.Conflict(
            "Worker.InvalidPermission",
            "Permissão inválida ou não existe");
        public static Error DoesNotBelongToStore => Error.Conflict(
                    "Worker.DoesNotBelongToStore",
                    "Este trabalhador não pertence à loja");
    }
}