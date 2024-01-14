using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Groups
    {
        public static Error NotFound => Error.Conflict(
            "Group.NotFound",
            "O grupo não foi encontrado.");
        
        public static Error CannotAccess => Error.Conflict(
            "Group.CannotAccess",
            "Não tem permissões para aceder ao grupo.");
    }
}
