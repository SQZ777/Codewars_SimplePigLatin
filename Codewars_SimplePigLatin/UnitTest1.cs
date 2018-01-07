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

        [TestMethod]
        public void PigPart_Input_ab_Should_Be_baay()
        {
            Assert.AreEqual("baay", Kata.PigPart("ab"));
        }

        [TestMethod]
        public void Input_ab_ba_Should_Be_baay_abay()
        {
            Assert.AreEqual("baay abay",Kata.PigIt("ab ba"));
        }

    }

    public class Kata
    {
        public static string PigPart(string s)
        {
            return s.Length > 0 ? s.Remove(0, 1) + s[0] + "ay" : string.Empty;
        }

        public static string PigIt(string str)
        {
            throw new System.NotImplementedException();
        }
    }
}
