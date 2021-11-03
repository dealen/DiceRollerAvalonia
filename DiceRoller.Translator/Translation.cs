using DiceRoller.Translator.Resources;

namespace DiceRoller.Translator
{
    public static class Translation
    {
        public static string Translate(string key)
        {
            return Language.ResourceManager.GetString(key);
        }
    }
}
