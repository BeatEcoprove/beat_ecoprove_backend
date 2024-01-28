using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Errors;

public partial class Errors
{
    public class FeedBack
    {
        public static Error TitleNotDefine => Error.Validation(
            "FeedBack.TitleNotDefine",
            "Por favor, introduza um título.");
        
        public static Error DescriptionNotProvided => Error.Validation(
            "FeedBack.DescriptionNotProvided",
            "Por favor, introduza uma descrição.");
        
        public static Error TitleMaxExceeded => Error.Validation(
            "FeedBack.TitleMaxExceeded",
            "O título não pode exceder os 100 caracteres.");

        public static Error TitleMinExceeded => Error.Validation(
            "FeedBack.TitleMinExceeded",
            "O título tem de ter pelo menos 5 caracteres.");

    }
}