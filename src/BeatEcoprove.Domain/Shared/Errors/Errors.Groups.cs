using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class Groups
    {
        public static Error NotFound => Error.Conflict(
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

        public static Error MemberNotFound => Error.Conflict(
            "Group.MemberNotFound",
            "Este membro não pertence ao grupo.");

        public static Error CannotPromoteToSameRole => Error.Conflict(
            "Group.CannotPromoteToSameRole",
            "Não pode promover um membro para o mesmo cargo.");

        public static Error DontBelongToGroup => Error.Conflict(
            "Group.DontBelongToGroup",
            "Não pertences a este grupo.");

        public static Error PermissionNotValid => Error.Conflict(
            "Group.PermissionNotValid",
            "Permissão invalida.");

        public static Error CannotPromoteMember => Error.Conflict(
            "Group.CannotPromoteMember",
            "Não tem permissões para promover este membro.");

        public static Error CannotPromoteYourself => Error.Conflict(
            "Group.CannotPromoteYourself",
            "Não pode promover-se a si mesmo");

        public static Error CannotKickMember => Error.Conflict(
            "Group.CannotKickMember",
            "Não foi possível remover o membro do grupo.");

        public static Error MemberAlreadyExists => Error.Conflict(
            "Group.MemberAlreadyExists",
            "Este membro já pertence ao grupo.");

        public static Error InviteNotFound => Error.Conflict(
            "Group.InviteNotFound",
            "Este convite não existe.");

        public static Error InviteAlreadyUsed => Error.Conflict(
            "Group.InviteAlreadyAccepted",
            "Este convite já foi utilizado.");
    }
}