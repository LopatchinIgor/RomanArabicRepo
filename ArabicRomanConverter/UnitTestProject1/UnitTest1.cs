using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArabicRomanConverter;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertRomanToArabicTest()
        {
            int expected = 19;
            ConvertRomanToArabic c = new ConvertRomanToArabic();
            var actual = c.Convert("XIX");
            Assert.AreEqual(expected, actual);
        }


    }
}
