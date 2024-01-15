using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class MaintenanceService 
    {
        public static Error NotFound => Error.Conflict(
            "MaintenanceService.NotFound",
            "O serviço selecionado não existe.");
        
        public static Error NotFoundAction => Error.Conflict(
            "MaintenanceService-Action.NotFound",
            "A action selecionada não existe.");
    }
}
