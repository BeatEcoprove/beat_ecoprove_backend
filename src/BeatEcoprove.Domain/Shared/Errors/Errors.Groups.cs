using BeatEcoprove.Domain.GroupAggregator;
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
        
        public static Error MemberNotFound => Error.Conflict(
            "Group.MemberNotFound",
            "Este membro não pertence ao grupo.");
        
        public static Error DontBelongToGroup => Error.Conflict(
            "Group.MemberNotFound",
            "Não pertences a este grupo.");
        
        public static Error PermissionNotValid => Error.Conflict(
            "Group.PermissionNotValid",
            "Permissão invalida.");
        
        public static Error CannotPromoteMember => Error.Conflict(
            "Group.PermissionNotValid",
            "Não tem permissões para promover este membro.");
        
        public static Error CannotPromoteYourself => Error.Conflict(
            "Group.CannotPromoteYourself",
            "Não pode promover-se a si mesmo");
        
        public static Error CannotKickMember => Error.Conflict(
            "Group.CannotKickMember",
            "Não foi possuível remover o membro do grupo."); 
    }
}
