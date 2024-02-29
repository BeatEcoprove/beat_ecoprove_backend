using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class MaintenanceService
    {
        public static Error NotFound => Error.Validation(
            "MaintenanceService.NotFound",
            "O serviço selecionado não existe.");

        public static Error NotFoundAction => Error.Validation(
            "MaintenanceService-Action.NotFound",
            "A action selecionada não existe.");
    }
}