using BeatEcoprove.Domain.GroupAggregator;
using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Groups
    {
        public static Error NotFound => Error.Validation(
            "Group.NotFound",
            "O grupo não foi encontrado.");

        public static Error WSNotFound => Error.Conflict(
            "Group.WSNotFound",
            "O grupo não foi encontrado.");

        public static Error WSIsntConnected => Error.Conflict(
            "Group.WSIsntConnected",
            "Não se encontra conectado a nenhum grupo.");

        public static Error CannotAccess => Error.Conflict(
            "Group.CannotAccess",
            "Não tem permissões para aceder ao grupo.");
        
        public static Error MemberNotFound => Error.Validation(
            "Group.MemberNotFound",
            "Este membro não pertence ao grupo.");
        
        public static Error CannotPromoteToSameRole => Error.Validation(
            "Group.CannotPromoteToSameRole",
            "Não pode promover um membro para o mesmo cargo.");
        
        public static Error DontBelongToGroup => Error.Validation(
            "Group.MemberNotFound",
            "Não pertences a este grupo.");
        
        public static Error PermissionNotValid => Error.Validation(
            "Group.PermissionNotValid",
            "Permissão invalida.");
        
        public static Error CannotPromoteMember => Error.Validation(
            "Group.PermissionNotValid",
            "Não tem permissões para promover este membro.");
        
        public static Error CannotPromoteYourself => Error.Validation(
            "Group.CannotPromoteYourself",
            "Não pode promover-se a si mesmo");
        
        public static Error CannotKickMember => Error.Validation(
            "Group.CannotKickMember",
            "Não foi possível remover o membro do grupo.");
        
        public static Error MemberAlreadyExists => Error.Validation(
            "Group.MemberAlreadyExists",
            "Este membro já pertence ao grupo.");
        
        public static Error InviteNotFound => Error.Validation(
            "Group.InviteNotFound",
            "Este convite não existe.");
        
        public static Error InviteAlreadyUsed => Error.Validation(
            "Group.InviteAlreadyAccepted",
            "Este convite já foi utilizado.");
    }
}
