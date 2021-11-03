using DiceRoller.Translations.Resources;

namespace DiceRoller.Translations
{
    public class Translation
    {
        public Translation() { }

        public static string Translate(string key) => Language.ResourceManager.GetString(key);
    }
}
