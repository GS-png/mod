using NeoModLoader.General;

namespace EraWheel.Localization;

public static class EraLocaleRegistrar
{
    public const string English = "en";
    public const string ChineseLegacy = "zh";
    public const string ChineseSimplified = "cz";
    public const string ChineseTraditional = "ch";

    public static void AddChinese(string key, string value)
    {
        LM.Add(ChineseLegacy, key, value);
        LM.Add(ChineseSimplified, key, value);
        LM.Add(ChineseTraditional, key, value);
    }

    public static void AddEnglish(string key, string value)
    {
        LM.Add(English, key, value);
    }

    public static void AddZhEn(string key, string zhValue, string enValue)
    {
        AddChinese(key, zhValue);
        AddEnglish(key, enValue);
    }
}
