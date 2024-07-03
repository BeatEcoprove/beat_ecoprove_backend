using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Store
    {
        public static Error RateNotAllowed => Error.Conflict(
            "Store.RateNotAllowed",
            "Valor não aceite para o rating da loja");
        
        public static Error CantCreateStore => Error.Conflict(
            "Store.CantCreateStore",
            "Não tens permissão para criar uma loja");        
        
        public static Error StoreNotFound => Error.NotFound(
            "Store.StoreNotFound",
            "Não existe nenhuma loja com esse id");  
        public static Error CouldNotDelete => Error.NotFound(
            "Store.CouldNotDelete", 
            "Não foi possível remover a loja");
        public static Error StoreAlreadyExistsName => Error.Conflict(
            "Store.StoreAlreadyExistsName",
            "Este nome já foi utilizado para o registro de uma loja");    
        
        public static Error DontHaveAccessToStore => Error.Conflict(
            "Store.DontHaveAccessToStore",
            "Não tens acesso a este recurso");
    }
}