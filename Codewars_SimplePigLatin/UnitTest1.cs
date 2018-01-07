using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_SimplePigLatin
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PigPart_Input_Empty_Should_Be_Empty()
        {
            Assert.AreEqual(string.Empty,Kata.PigPart(string.Empty));
        }
    }

    public class Kata
    {
        public static string PigPart(string s)
        {
            throw new System.NotImplementedException();
        }
    }
}
