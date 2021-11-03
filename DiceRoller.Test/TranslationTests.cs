using DiceRoller.Translations;
using NUnit.Framework;
using System.Globalization;
using System.Threading;

namespace DiceRoller.Test
{
    public class TranslationTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CanTranslate()
        {
            var value = "d6";
            
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            var translationDefault = Translation.Translate(value);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pl-PL");
            var translationPL = Translation.Translate(value);

            Assert.AreEqual("k6", translationPL);
            Assert.AreEqual("d6", translationDefault);
        }
    }
}