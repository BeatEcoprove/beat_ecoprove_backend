namespace BeatEcoprove.Application.Shared.Multilanguage;

public interface ILanguageCulture
{
    string GetChunk(string key, string fallback = "");
    Language GetCurrentCulture();
    void SetLanguage(Language language);
}