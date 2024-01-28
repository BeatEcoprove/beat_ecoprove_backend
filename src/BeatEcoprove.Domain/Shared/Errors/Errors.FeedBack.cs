using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class FeedBack
    {
        public static Error TitleNotDefine => Error.Conflict(
            "FeedBack.TitleNotDefine",
            "Por favor, introduza um título.");
        
        public static Error DescriptionNotProvided => Error.Conflict(
            "FeedBack.DescriptionNotProvided",
            "Por favor, introduza uma descrição.");
        
        public static Error TitleMaxExceeded => Error.Conflict(
            "FeedBack.TitleMaxExceeded",
            "O título não pode exceder os 100 caracteres.");

        public static Error TitleMinExceeded => Error.Conflict(
            "FeedBack.TitleMinExceeded",
            "O título tem de ter pelo menos 5 caracteres.");

    }
}