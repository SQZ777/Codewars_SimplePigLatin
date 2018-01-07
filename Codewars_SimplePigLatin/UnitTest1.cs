using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_SimplePigLatin
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PigPart_Input_Empty_Should_Be_Empty()
        {
            Assert.AreEqual(string.Empty, Kata.PigPart(string.Empty));
        }

        [TestMethod]
        public void PigPart_Input_a_Should_Be_aay()
        {
            Assert.AreEqual("aay", Kata.PigPart("a"));
        }

    }

    public class Kata
    {
        public static string PigPart(string s)
        {
            if (s.Length > 0)
            {
                return s + "ay";
            }
            return string.Empty;
        }
    }
}
